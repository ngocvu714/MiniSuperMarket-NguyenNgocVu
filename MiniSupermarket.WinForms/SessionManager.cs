using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading.Tasks;

namespace MiniSupermarket.WinForms
{
    // Lớp tĩnh lưu trữ thông tin phiên làm việc (Token và Vai trò)
    public static class SessionManager
    {
        public static string JwtToken { get; set; } = string.Empty;
        public static string CurrentRole { get; set; } = string.Empty;

        // BỔ SUNG: Hàm xóa sạch thông tin phiên làm việc khi Đăng xuất
        public static void Clear()
        {
            JwtToken = string.Empty;
            CurrentRole = string.Empty;
        }
    }

    // Lớp dịch vụ hỗ trợ gọi API từ WinForms
    public static class ApiClientService
    {
        // ⚠️ LƯU Ý: Thay đổi số Port "7159" (hoặc "7123") thành đúng Port mà Backend Web API của bạn đang chạy
        private static readonly HttpClient _client = new HttpClient
        {
            BaseAddress = new Uri("https://localhost:7159/api/")
        };

        // Hàm gọi API đăng nhập để lấy Token và Role
        public static async Task<bool> LoginAsync(string username, string password)
        {
            var loginObj = new { Username = username, Password = password };
            var response = await _client.PostAsJsonAsync("auth/login", loginObj);

            if (response.IsSuccessStatusCode)
            {
                var jsonString = await response.Content.ReadAsStringAsync();
                using var doc = JsonDocument.Parse(jsonString);

                // Trích xuất "token" và "role" từ JSON trả về và lưu vào SessionManager
                SessionManager.JwtToken = doc.RootElement.GetProperty("token").GetString() ?? string.Empty;
                SessionManager.CurrentRole = doc.RootElement.GetProperty("role").GetString() ?? string.Empty;
                return true;
            }
            return false;
        }

        // Hàm gọi API lấy dữ liệu có tự động đính kèm Bearer Token bảo mật
        public static async Task<string> GetDataWithTokenAsync(string endpoint)
        {
            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", SessionManager.JwtToken);
            var response = await _client.GetAsync(endpoint);

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsStringAsync();
            }
            else if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
            {
                throw new Exception("Phiên làm việc hết hạn hoặc chưa đăng nhập!");
            }

            throw new Exception("Lỗi khi gọi dữ liệu từ Server.");
        }
    }
}