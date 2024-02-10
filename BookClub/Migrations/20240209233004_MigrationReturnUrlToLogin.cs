﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookClub.Migrations
{
    /// <inheritdoc />
    public partial class MigrationReturnUrlToLogin : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ReturnUrl",
                table: "Logins",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ReturnUrl",
                table: "Logins");
        }
    }
}
