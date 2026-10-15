📝 BÁO CÁO CÔNG VIỆC BUỔI 4 - DỰ ÁN BÁCH HÓA MINI HỒNG PHÁT
## 📂 Cấu trúc thư mục dự án (Project Structure)

```text
MiniSupermarket/
├── 📄 README.md                                  # Tài liệu hướng dẫn & Báo cáo công việc
├── 📄 MiniSupermarket.sln                       # Visual Studio Solution File
│
├── 📁 MiniSupermarket.API/                      # Backend Web API (ASP.NET Core Web API)
│   ├── 📁 Controllers/                          # API RESTful Controllers
│   │   ├── AuthController.cs                    # Xử lý Đăng nhập & Cấp phát JWT Token
│   │   ├── CategoriesController.cs              # Quản lý Danh mục sản phẩm (CRUD)
│   │   ├── CustomerController.cs                # Quản lý Khách hàng & Tích điểm (CRUD)
│   │   ├── OrdersController.cs                  # Xử lý Hóa đơn & Đơn hàng POS
│   │   ├── ProductsController.cs                # Quản lý Sản phẩm & Tồn kho (CRUD)
│   │   ├── RolesController.cs                   # Quản lý Chức năng Phân quyền
│   │   └── UsersController.cs                   # Quản lý Tài khoản Nhân viên
│   ├── 📁 Data/                                 # Cấu hình Entity Framework Core
│   │   └── SupermarketDbContext.cs              # DbContext & Seed Data Bách hóa Hồng Phát
│   ├── 📁 Migrations/                           # Các bản Migration của Database SQL Server
│   ├── 📁 Models/                               # Entities Mapping với Database
│   │   ├── Category.cs
│   │   ├── Customer.cs
│   │   ├── Order.cs
│   │   ├── OrderDetail.cs
│   │   ├── Product.cs
│   │   ├── Roles.cs
│   │   └── User.cs
│   ├── 📄 appsettings.json                      # Cấu hình Chuỗi kết nối SQL Server & JWT Key
│   └── 📄 Program.cs                            # Khởi tạo Web API Service & Middleware
│
└── 📁 MiniSupermarket.WinForm/                  # Frontend Giao diện Quản lý (C# WinForms)
    ├── 📁 Forms/                                # Các Form Giao diện Chức năng
    │   ├── FormCategoryManagement.cs            # Giao diện Quản lý Danh mục
    │   ├── FormCustomerManagement.cs            # Giao diện Quản lý Khách hàng
    │   ├── FormLogin.cs                         # Giao diện Đăng nhập Hệ thống
    │   ├── FormMainShell.cs                     # Cửa sổ chính (Shell) chứa Sidebar/Header
    │   ├── FormPOS.cs                           # Giao diện Quầy Bán hàng & Thu ngân
    │   ├── FormProductManagement.cs             # Giao diện Quản lý Sản phẩm & Tồn kho
    │   ├── FormQuickReport.cs                   # Giao diện Báo cáo Doanh thu
    │   └── FormUserManagement.cs                # Giao diện Quản trị Tài khoản Nhân viên
    ├── 📄 SessionManager.cs                     # Lưu trữ Token JWT & Phiên làm việc
    └── 📄 Program.cs

🎯 Mục Tiêu Buổi Học

Thiết lập và hoàn thiện hệ thống cơ sở dữ liệu (Database) cho dự án "Xây dựng Giải pháp Quản lý Kho và Thanh toán Điện tử cho Cửa hàng Mini - Bách hóa Mini Hồng Phát".

Đồng bộ hóa Model Entity Framework Core (EF Core) với cơ sở dữ liệu SQL Server.

Khởi tạo dữ liệu mẫu (Data Seeding) chuẩn hóa cho thương hiệu Bách hóa Mini Hồng Phát.

Kiểm tra tính năng kết nối giữa WinForms Shell Client và Web API Server.

🛠️ Các Công Việc Đã Thực Hiện

1. Khởi Tạo & Đồng Bộ Cơ Sở Dữ Liệu (EF Core Code-First)

Xây dựng file SupermarketDbContext.cs với đầy đủ cấu trúc quan hệ giữa các bảng:

Categories (Danh mục sản phẩm)

Products (Sản phẩm kho)

Customers (Khách hàng)

Roles (Vai trò)

Users (Tài khoản nhân viên)

Orders & OrderDetails (Đơn hàng và Chi tiết đơn hàng)

Thực hiện xử lý lỗi build, làm sạch lịch sử migration và chạy các lệnh EF Core thành công:

Add-Migration InitialCreateDatabaseV2

Update-Database

Cấu hình chuỗi kết nối kết nối thành công với cơ sở dữ liệu SQL Server (NguyenNgocVu-SupermarketDb).

2. Nạp Dữ Liệu Mẫu (Data Seeding) - Bách Hóa Mini Hồng Phát

15 Danh mục sản phẩm (Categories): Bao gồm Gạo & Lương thực, Mì/Phở/Cháo, Gia vị nhà bếp, Đồ uống giải khát, Sữa & Sản phẩm từ sữa, Bánh kẹo & Snack, Hóa mỹ phẩm, v.v.

15 Sản phẩm tiêu biểu (Products): Được gán mã Barcode chuẩn (HP8935001001 - HP8935001015), đơn vị tính, giá bán và số lượng tồn kho thực tế.

15 Khách hàng thành viên (Customers): Tích hợp thông tin phân hạng (Kim Cương, Vàng, Bạc, Thân Thiết) và điểm thưởng.

3 Vai trò hệ thống (Roles): Admin, Cashier (Thu ngân), Warehouse (Quản lý kho).

15 Tài khoản nhân viên (Users): Phân quyền đúng với 3 vai trò hệ thống để phục vụ kiểm thử tính năng RBAC.

3. Cấu Hình & Kiểm Thử Hệ Thống

Thiết lập cấu hình Multiple Startup Projects trong Visual Studio để khởi chạy đồng thời cả hai dự án:

MiniSupermarket.API (Web API Server trên cổng 7292)

MiniSupermarket.WinForm (Client UI)

Sửa lỗi kết nối Connection Refused (localhost:7292) và kiểm tra thành công luồng đăng nhập phân quyền từ WinForms thông qua API.

🚀 Hướng Dẫn Chạy Dự Án

Mở Solution MiniSupermarket.sln trong Visual Studio.

Kiểm tra chuỗi kết nối kết nối trong file appsettings.json tại project MiniSupermarket.API.

Nhấp chuột phải vào Solution -> chọn Properties -> chọn Multiple startup projects -> Đặt Action của MiniSupermarket.API và MiniSupermarket.WinForm thành Start.

Nhấn F5 để chạy dự án.

Sử dụng các tài khoản thử nghiệm:

Admin: admin01 / 123456

Thu ngân (Cashier): cashier01 / 123456

Thủ kho (Warehouse): ware01 / 123456

Ngày hoàn tất: 15/10/2026
Ho ten SV: Nguyen Ngoc Vu
MSSV: 2124110251
