using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HomeGroom.Migrations
{
    public partial class mig8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DateandTime",
                table: "Services",
                newName: "Time");

            migrationBuilder.RenameColumn(
                name: "Address",
                table: "Services",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "DateandTime",
                table: "CartItems",
                newName: "Time");

            migrationBuilder.AddColumn<string>(
                name: "Address1",
                table: "Services",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Address2",
                table: "Services",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "Services",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Mob",
                table: "Services",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "CartItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "CartItems",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "mob",
                table: "CartItems",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address1",
                table: "Services");

            migrationBuilder.DropColumn(
                name: "Address2",
                table: "Services");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "Services");

            migrationBuilder.DropColumn(
                name: "Mob",
                table: "Services");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "CartItems");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "CartItems");

            migrationBuilder.DropColumn(
                name: "mob",
                table: "CartItems");

            migrationBuilder.RenameColumn(
                name: "Time",
                table: "Services",
                newName: "DateandTime");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Services",
                newName: "Address");

            migrationBuilder.RenameColumn(
                name: "Time",
                table: "CartItems",
                newName: "DateandTime");
        }
    }
}
