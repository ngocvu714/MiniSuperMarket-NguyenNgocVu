using Microsoft.AspNetCore.Authorization; // Namespace hỗ trợ thuộc tính [Authorize]
using Microsoft.AspNetCore.Mvc;
using MiniSupermarket.API.Models;

namespace MiniSupermarket.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize] // Yêu cầu bắt buộc đăng nhập cho toàn bộ Controller
    public class CategoriesController : ControllerBase
    {
        private static readonly List<Category> _categories = new() {
            new Category { CategoryId = 1, CategoryName = "Bánh kẹo & Đồ ăn vặt", Description = "Snack, bánh quy, kẹo dẻo" },
            new Category { CategoryId = 2, CategoryName = "Nước giải khát & Trà", Description = "Nước ngọt, nước khoáng, trà" },
            new Category { CategoryId = 3, CategoryName = "Sữa & Sản phẩm từ sữa", Description = "Sữa tươi, sữa chua, phô mai" },
            new Category { CategoryId = 4, CategoryName = "Mì gói & Thực phẩm ăn liền", Description = "Mì ăn liền, phở khô, cháo gói" },
            new Category { CategoryId = 5, CategoryName = "Gia vị & Dầu ăn", Description = "Nước mắm, hạt nêm, dầu thực vật" }
        };

        // 1. READ ALL: Cả Admin và Cashier đều xem được danh sách
        [HttpGet]
        [Authorize(Roles = "Admin,Cashier")]
        public IActionResult GetAll()
        {
            return Ok(_categories);
        }

        // 2. READ DETAIL: Cả Admin và Cashier đều xem được chi tiết
        [HttpGet("{id}")]
        [Authorize(Roles = "Admin,Cashier")]
        public IActionResult GetById(int id)
        {
            var cat = _categories.FirstOrDefault(c => c.CategoryId == id);
            if (cat == null)
            {
                return NotFound(new { message = "Không tìm thấy nhóm hàng!" });
            }
            return Ok(cat);
        }

        // 3. SEARCH: Cả Admin và Cashier đều tìm kiếm được
        [HttpGet("search")]
        [Authorize(Roles = "Admin,Cashier")]
        public IActionResult Search([FromQuery] string keyword)
        {
            if (string.IsNullOrWhiteSpace(keyword))
            {
                return BadRequest(new { message = "Vui lòng nhập từ khóa!" });
            }
            var result = _categories
                .Where(c => c.CategoryName.Contains(keyword, StringComparison.OrdinalIgnoreCase))
                .ToList();
            return Ok(result);
        }

        // =========================================================================
        // CHỈ ADMIN MỚI CÓ QUYỀN CAN THIỆP THÊM / SỬA / XÓA
        // =========================================================================

        // 4. CREATE: Chỉ Admin được thêm mới
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public IActionResult Create([FromBody] Category newCat)
        {
            if (string.IsNullOrWhiteSpace(newCat.CategoryName))
            {
                return BadRequest(new { message = "Tên không được trống!" });
            }
            newCat.CategoryId = _categories.Count > 0 ? _categories.Max(c => c.CategoryId) + 1 : 1;
            _categories.Add(newCat);

            return CreatedAtAction(nameof(GetById), new { id = newCat.CategoryId }, newCat);
        }

        // 5. UPDATE: Chỉ Admin được sửa
        [HttpPut("{id}")]
        [Authorize(Roles = "Admin")]
        public IActionResult Update(int id, [FromBody] Category updateCat)
        {
            var cat = _categories.FirstOrDefault(c => c.CategoryId == id);
            if (cat == null)
            {
                return NotFound(new { message = "Không tìm thấy nhóm hàng cần sửa!" });
            }
            cat.CategoryName = updateCat.CategoryName;
            cat.Description = updateCat.Description;

            return NoContent();
        }

        // 6. DELETE: Chỉ Admin được xóa
        [HttpDelete("{id}")]
        [Authorize(Roles = "Admin")]
        public IActionResult Delete(int id)
        {
            var cat = _categories.FirstOrDefault(c => c.CategoryId == id);
            if (cat == null)
            {
                return NotFound(new { message = "Không tìm thấy nhóm hàng cần xóa!" });
            }
            _categories.Remove(cat);
            return NoContent();
        }

        // =========================================================================
        // 7. ENDPOINT KIỂM TRA PHÂN QUYỀN
        // =========================================================================

        [HttpGet("admin-dashboard")]
        [Authorize(Roles = "Admin")]
        public IActionResult GetAdminDashboard()
        {
            return Ok(new { message = "Chào mừng Admin! Bạn có toàn quyền quản trị hệ thống siêu thị mini." });
        }

        [HttpGet("staff-pos")]
        [Authorize(Roles = "Admin,Cashier")]
        public IActionResult GetStaffPos()
        {
            return Ok(new { message = "Màn hình POS Thu ngân sẵn sàng phục vụ bán hàng." });
        }
    }
}