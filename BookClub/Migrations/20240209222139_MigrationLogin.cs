using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookClub.Migrations
{
    /// <inheritdoc />
    public partial class MigrationLogin : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Logins",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Logins", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "https://sun9-39.userapi.com/impg/kl1PiBYGZCRXMYpO9UuwaODuyMp2o5mCZxif0w/GzwGaBJWk9Q.jpg?size=556x807&quality=96&sign=20e286d6b8fe8e2bf1306b551c1276f2&c_uniq_tag=NktdlktIn7ul5i56FpbQKAf8ZZdhs0_LUAKqY-UAFNI&type=album");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Logins");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "https://cache3.youla.io/files/images/780_780/5e/7f/5e7f844e4aa7e546bc6ddb74.jpg");
        }
    }
}
