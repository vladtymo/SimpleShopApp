using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SimpleShopApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Discount", "ImageUrl", "Name", "Price", "Quantity" },
                values: new object[,]
                {
                    { 1, "The Most Innovative Lineup Yet\r\n\r\niPhone 16 and iPhone 16 Plus are built for Apple Intelligence, and feature Camera Control, the Action button, a 48MP Fusion camera, and the A18 chip. Camera Control makes it even easier to capture memories on iPhone 16 Pro and iPhone 16.", 0, "https://my-apple.com.ua/image/catalog/products/iphone/iphone-16-pro-16-pro-max/desert-titanium-1.png", "iPhone 16 Pro", 1199m, 0 },
                    { 2, "Emberton II delivers sound that is rich, clear and loud, like the artist intended. Experience absolute 360° sound with True Stereophonic, a unique form of multi-directional sound fromMarshall – where every spot is a sweet spot. Emberton II offers 30+ hours of portable playtime on a single charge.", 15, "https://www.marshall.com.ua/components/com_jshopping/files/img_products/full_marshall-emberton-ii-cream_detail02.jpg", "Marshall Emberton II", 159m, 2 },
                    { 3, "AirPods Max are wireless Bluetooth over-ear headphones designed by Apple, and released on December 15, 2020. They are Apple's highest-end option in the AirPods lineup, sold alongside the base model AirPods and mid-range AirPods Pro.\r\n\r\nThe main changes of the AirPods Max over the mid-range AirPods Pro are the over-ear design with larger speakers, inclusion of Apple's Digital Crown (found on the Apple Watch), more color options, and longer battery life.", 0, "https://skay.ua/109669-thickbox_default/besprovodnye-naushniki-apple-airpods-max-pink-mgym3.jpg", "AirPods Max", 499m, 35 },
                    { 4, "Redmi Note 13's display has been optimized for improved touch recognition and control, preventing accidental triggers from water. With MIUI exclusive optimization, Redmi Note 13 has also passed extensive testing to ensure minimal software aging and slowdowns, even after 48 months of use*.", 10, "https://content1.rozetka.com.ua/goods/images/big/428176969.jpg", "Xiaomi Redmi Note 13", 359m, 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Products");

            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
