﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OrderServise.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class dgdrgghuy : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address_HomeAddresses_City",
                schema: "ordering",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Address_HomeAddresses_PostalCode",
                schema: "ordering",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Address_HomeAddresses_Street",
                schema: "ordering",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Address_WorkAddresses_City",
                schema: "ordering",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Address_WorkAddresses_PostalCode",
                schema: "ordering",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "Address_WorkAddresses_Street",
                schema: "ordering",
                table: "AspNetUsers",
                newName: "Address");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Address",
                schema: "ordering",
                table: "AspNetUsers",
                newName: "Address_WorkAddresses_Street");

            migrationBuilder.AddColumn<string>(
                name: "Address_HomeAddresses_City",
                schema: "ordering",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Address_HomeAddresses_PostalCode",
                schema: "ordering",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Address_HomeAddresses_Street",
                schema: "ordering",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Address_WorkAddresses_City",
                schema: "ordering",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Address_WorkAddresses_PostalCode",
                schema: "ordering",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
