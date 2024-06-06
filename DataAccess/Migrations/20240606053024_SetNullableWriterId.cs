﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class SetNullableWriterId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
			migrationBuilder.AlterColumn<int>(
			name: "WriterId",
			table: "Articles",
			nullable: true,
			oldClrType: typeof(int),
			oldType: "int");
		}

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
			migrationBuilder.AlterColumn<int>(
			name: "WriterId",
			table: "Articles",
			nullable: false,
			oldClrType: typeof(int),
			oldType: "int");
		}
    }
}
