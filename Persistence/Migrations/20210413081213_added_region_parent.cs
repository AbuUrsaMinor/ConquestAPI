using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class added_region_parent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Coastal",
                table: "Regions",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<Guid>(
                name: "ParentId",
                table: "Regions",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Regions_ParentId",
                table: "Regions",
                column: "ParentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Regions_Regions_ParentId",
                table: "Regions",
                column: "ParentId",
                principalTable: "Regions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Regions_Regions_ParentId",
                table: "Regions");

            migrationBuilder.DropIndex(
                name: "IX_Regions_ParentId",
                table: "Regions");

            migrationBuilder.DropColumn(
                name: "Coastal",
                table: "Regions");

            migrationBuilder.DropColumn(
                name: "ParentId",
                table: "Regions");
        }
    }
}
