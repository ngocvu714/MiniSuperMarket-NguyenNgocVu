using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MiniSupermarket.API.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreateDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                column: "Description",
                value: "Gạo ST25 Hồng Phát, gạo nở, nếp nương, đậu xanh");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                column: "CategoryName",
                value: "Gia vị & Dầu ăn kho");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3,
                column: "Description",
                value: "Mì gói, phở khô, bún tươi, hủ tiếu ăn liền");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 8,
                column: "Description",
                value: "Xà bông, dầu gội, nước rửa chén, nước lau nhà");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 10,
                columns: new[] { "CategoryName", "Description" },
                values: new object[] { "Đồ dùng gia đình & Kho vận", "Băng dính đóng gói, túi rác, màng bọc thực phẩm" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 13,
                column: "Description",
                value: "Bia lon, rượu nếp, rượu vang Hồng Phát");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "Barcode", "Price", "ProductName", "StockQuantity" },
                values: new object[] { "HP8935001001", 185000m, "Gạo ST25 Hồng Phát Đặc Sản 5kg", 120 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "Barcode", "ProductName", "StockQuantity" },
                values: new object[] { "HP8935001002", "Nước mắm Nam Ngư Đột Phá 500ml", 200 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "Barcode", "Price", "StockQuantity" },
                values: new object[] { "HP8935001003", 118000m, 85 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                columns: new[] { "Barcode", "StockQuantity" },
                values: new object[] { "HP8935001004", 150 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                columns: new[] { "Barcode", "StockQuantity" },
                values: new object[] { "HP8935001005", 300 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                columns: new[] { "Barcode", "StockQuantity" },
                values: new object[] { "HP8935001006", 90 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7,
                columns: new[] { "Barcode", "StockQuantity" },
                values: new object[] { "HP8935001007", 60 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8,
                columns: new[] { "Barcode", "StockQuantity" },
                values: new object[] { "HP8935001008", 110 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9,
                columns: new[] { "Barcode", "StockQuantity" },
                values: new object[] { "HP8935001009", 140 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10,
                columns: new[] { "Barcode", "ProductName", "StockQuantity" },
                values: new object[] { "HP8935001010", "Túi rác sinh học Hồng Phát 1kg", 95 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11,
                columns: new[] { "Barcode", "StockQuantity" },
                values: new object[] { "HP8935001011", 40 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 12,
                columns: new[] { "Barcode", "StockQuantity" },
                values: new object[] { "HP8935001012", 70 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 13,
                columns: new[] { "Barcode", "StockQuantity" },
                values: new object[] { "HP8935001013", 50 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 14,
                columns: new[] { "Barcode", "StockQuantity" },
                values: new object[] { "HP8935001014", 80 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 15,
                columns: new[] { "Barcode", "ProductName", "StockQuantity" },
                values: new object[] { "HP8935001015", "Hương trầm thảo mộc Hồng Phát 100 nén", 100 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                column: "Description",
                value: "Gạo ST25, gạo nở, nếp nương, đậu xanh, đậu đỏ");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                column: "CategoryName",
                value: "Gia vị & Dầu ăn");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3,
                column: "Description",
                value: "Mì gói, phở khô, bún tươi, hủ tiếu, cháo ăn liền");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 8,
                column: "Description",
                value: "Xà bông, dầu gội, nước rửa chén, nước lau nhà, bột giặt");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 10,
                columns: new[] { "CategoryName", "Description" },
                values: new object[] { "Đồ dùng gia đình & Gia dụng", "Băng dính, túi rác, màng bọc thực phẩm, chổi, khăn lau" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 13,
                column: "Description",
                value: "Bia lon, rượu nếp, rượu vang");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "Barcode", "Price", "ProductName", "StockQuantity" },
                values: new object[] { "8935001001", 180000m, "Gạo Ông Thọ ST25 5kg", 50 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "Barcode", "ProductName", "StockQuantity" },
                values: new object[] { "8935001002", "Nước mắm Nam Ngư 500ml", 120 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "Barcode", "Price", "StockQuantity" },
                values: new object[] { "8935001003", 115000m, 40 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                columns: new[] { "Barcode", "StockQuantity" },
                values: new object[] { "8935001004", 80 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                columns: new[] { "Barcode", "StockQuantity" },
                values: new object[] { "8935001005", 150 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                columns: new[] { "Barcode", "StockQuantity" },
                values: new object[] { "8935001006", 60 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7,
                columns: new[] { "Barcode", "StockQuantity" },
                values: new object[] { "8935001007", 45 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8,
                columns: new[] { "Barcode", "StockQuantity" },
                values: new object[] { "8935001008", 90 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9,
                columns: new[] { "Barcode", "StockQuantity" },
                values: new object[] { "8935001009", 100 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10,
                columns: new[] { "Barcode", "ProductName", "StockQuantity" },
                values: new object[] { "8935001010", "Túi rác tự hủy sinh học 1kg", 75 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11,
                columns: new[] { "Barcode", "StockQuantity" },
                values: new object[] { "8935001011", 30 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 12,
                columns: new[] { "Barcode", "StockQuantity" },
                values: new object[] { "8935001012", 50 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 13,
                columns: new[] { "Barcode", "StockQuantity" },
                values: new object[] { "8935001013", 35 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 14,
                columns: new[] { "Barcode", "StockQuantity" },
                values: new object[] { "8935001014", 65 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 15,
                columns: new[] { "Barcode", "ProductName", "StockQuantity" },
                values: new object[] { "8935001015", "Hương trầm thảo mộc cao cấp 100 nén", 85 });
        }
    }
}
