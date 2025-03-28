﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AplicatieMagazinOnline.Data.Migrations
{
    public partial class BookApproved : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Approved",
                table: "Books",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Approved",
                table: "Books");
        }
    }
}
