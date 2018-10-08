using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Magazzino.web.Migrations
{
    public partial class baseEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                schema: "dbo",
                table: "User");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                schema: "dbo",
                table: "User");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                schema: "dbo",
                table: "User");

            migrationBuilder.DropColumn(
                name: "ModifyByUserId",
                schema: "dbo",
                table: "User");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                schema: "dbo",
                table: "Seller");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                schema: "dbo",
                table: "Seller");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                schema: "dbo",
                table: "Seller");

            migrationBuilder.DropColumn(
                name: "ModifyByUserId",
                schema: "dbo",
                table: "Seller");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                schema: "dbo",
                table: "Sales");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                schema: "dbo",
                table: "Sales");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                schema: "dbo",
                table: "Sales");

            migrationBuilder.DropColumn(
                name: "ModifyByUserId",
                schema: "dbo",
                table: "Sales");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                schema: "dbo",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                schema: "dbo",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                schema: "dbo",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "ModifyByUserId",
                schema: "dbo",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                schema: "dbo",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                schema: "dbo",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                schema: "dbo",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "ModifyByUserId",
                schema: "dbo",
                table: "Customer");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CreatedByUserId",
                schema: "dbo",
                table: "User",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                schema: "dbo",
                table: "User",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                schema: "dbo",
                table: "User",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "ModifyByUserId",
                schema: "dbo",
                table: "User",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CreatedByUserId",
                schema: "dbo",
                table: "Seller",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                schema: "dbo",
                table: "Seller",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                schema: "dbo",
                table: "Seller",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "ModifyByUserId",
                schema: "dbo",
                table: "Seller",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CreatedByUserId",
                schema: "dbo",
                table: "Sales",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                schema: "dbo",
                table: "Sales",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                schema: "dbo",
                table: "Sales",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "ModifyByUserId",
                schema: "dbo",
                table: "Sales",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CreatedByUserId",
                schema: "dbo",
                table: "Product",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                schema: "dbo",
                table: "Product",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                schema: "dbo",
                table: "Product",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "ModifyByUserId",
                schema: "dbo",
                table: "Product",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CreatedByUserId",
                schema: "dbo",
                table: "Customer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                schema: "dbo",
                table: "Customer",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                schema: "dbo",
                table: "Customer",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "ModifyByUserId",
                schema: "dbo",
                table: "Customer",
                nullable: false,
                defaultValue: 0);
        }
    }
}
