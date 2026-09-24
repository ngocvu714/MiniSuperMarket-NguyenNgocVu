namespace MiniSupermarket.WinForms
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // Vòng lặp duy trì phiên làm việc của ứng dụng
            while (true)
            {
                // 1. Khởi chạy Form Đăng nhập
                FormLogin loginForm = new FormLogin();

                // Nếu đăng nhập thành công (FormLogin trả về DialogResult.OK)
                if (loginForm.ShowDialog() == DialogResult.OK)
                {
                    // 2. Mở Form Quản lý danh mục
                    FormCategoryManagement mainForm = new FormCategoryManagement();
                    DialogResult result = mainForm.ShowDialog();

                    // Nếu Form chính đóng lại KHÔNG PHẢI do Đăng xuất (DialogResult != OK)
                    // nghĩa là người dùng bấm nút [X] thoát ứng dụng -> Thoát hẳn
                    if (result != DialogResult.OK)
                    {
                        break;
                    }
                }
                else
                {
                    // Người dùng bấm [X] hoặc Hủy ở Form Đăng nhập -> Thoát ứng dụng
                    break;
                }
            }
        }
    }
}