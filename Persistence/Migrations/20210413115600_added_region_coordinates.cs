using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class added_region_coordinates : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "RegionCoordinates",
                columns: new[] { "CoordinateId", "RegionId" },
                values: new object[] { new Guid("90774271-f4c5-409d-b51c-b02c9e2b781f"), new Guid("921225c3-3253-470d-8dbf-df1f130dec93") });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RegionCoordinates",
                keyColumns: new[] { "CoordinateId", "RegionId" },
                keyValues: new object[] { new Guid("90774271-f4c5-409d-b51c-b02c9e2b781f"), new Guid("921225c3-3253-470d-8dbf-df1f130dec93") });
        }
    }
}
