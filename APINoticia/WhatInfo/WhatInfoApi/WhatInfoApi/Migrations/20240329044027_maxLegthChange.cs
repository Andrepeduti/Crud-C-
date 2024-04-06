using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WhatInfoApi.Migrations
{
    /// <inheritdoc />
    public partial class maxLegthChange : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder mb)
        {
            mb.AlterColumn<string>(
                name: "NoticiaTitulo",
                table: "noticias",
                maxLength: 70,
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
