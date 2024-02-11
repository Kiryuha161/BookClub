using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookClub.Migrations
{
    /// <inheritdoc />
    public partial class MigrationReadBookUsersToBook : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserReadBooks",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "UserReadBooks",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "UserReadBooks",
                keyColumn: "Id",
                keyValue: 3);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "UserReadBooks",
                columns: new[] { "Id", "BookId", "IsRead", "UserId" },
                values: new object[,]
                {
                    { 1, 1, false, 13 },
                    { 2, 2, false, 13 },
                    { 3, 1, false, 14 }
                });
        }
    }
}
