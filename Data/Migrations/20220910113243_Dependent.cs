using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace App.Data.Migrations
{
    public partial class Dependent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "NextOfKinAddress",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "NextOfKinEmail",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "NextOfKinName",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "NextOfKinPhone",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Relationship",
                table: "AspNetUsers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NextOfKinAddress",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "NextOfKinEmail",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "NextOfKinName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "NextOfKinPhone",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Relationship",
                table: "AspNetUsers");
        }
    }
}
