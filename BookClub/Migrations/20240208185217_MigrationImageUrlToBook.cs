using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookClub.Migrations
{
    /// <inheritdoc />
    public partial class MigrationImageUrlToBook : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Books",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "https://files.books.ru/pic/3557001-3558000/3557131/973108900c.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "https://cache3.youla.io/files/images/780_780/5e/7f/5e7f844e4aa7e546bc6ddb74.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Author", "ImageUrl" },
                values: new object[] { "Эндрю Стиллмен", "https://synergy.ru/assets/upload/news/academy/and4.jpg" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageUrl",
                value: "https://ndc.book24.ru/resize/820x1180/iblock/90f/90f0287fb8b4ad1c57e2613dfa5f2aeb/ff8757b0dfcc866833e499090194d9cd.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageUrl",
                value: "https://cdn.img-gorod.ru/nomenclature/28/687/2868777.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImageUrl",
                value: "https://avatars.mds.yandex.net/i?id=58cc02a626f1bdc1260a3e0cec5db747728d30f2-10640163-images-thumbs&n=13");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                column: "ImageUrl",
                value: "https://img2.festima.ru/1/yAhOQTG6uAPG1wen");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Books");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                column: "Author",
                value: "Эндрю Стиллмен ");
        }
    }
}
