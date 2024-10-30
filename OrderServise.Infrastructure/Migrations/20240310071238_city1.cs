﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OrderServise.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class city1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Cities_CityId",
                schema: "ordering",
                table: "Products");

            migrationBuilder.AlterColumn<int>(
                name: "CityId",
                schema: "ordering",
                table: "Products",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Cities_CityId",
                schema: "ordering",
                table: "Products",
                column: "CityId",
                principalSchema: "ordering",
                principalTable: "Cities",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Cities_CityId",
                schema: "ordering",
                table: "Products");

            migrationBuilder.AlterColumn<int>(
                name: "CityId",
                schema: "ordering",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Cities_CityId",
                schema: "ordering",
                table: "Products",
                column: "CityId",
                principalSchema: "ordering",
                principalTable: "Cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
