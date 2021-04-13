using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class fixed_parent_seeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("3cfed3d0-0ba6-47d7-8f23-dcb912751016"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("66c1afdf-5ada-4cfa-b55d-03ae6d8618d8"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("921228c3-3253-470d-8dbf-df1f130dec93"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("933a7054-36c8-4a80-897b-52cd16115925"));

            migrationBuilder.InsertData(
                table: "Regions",
                columns: new[] { "Id", "Coastal", "Name", "ParentId" },
                values: new object[] { new Guid("921225c3-3253-470d-8dbf-df1f130dec93"), true, "Stockholm", null });

            migrationBuilder.InsertData(
                table: "Regions",
                columns: new[] { "Id", "Coastal", "Name", "ParentId" },
                values: new object[] { new Guid("953a7054-36c8-4a80-897b-52cd16115925"), true, "Solna", new Guid("921225c3-3253-470d-8dbf-df1f130dec93") });

            migrationBuilder.InsertData(
                table: "Regions",
                columns: new[] { "Id", "Coastal", "Name", "ParentId" },
                values: new object[] { new Guid("3cfed5d0-0ba6-47d7-8f23-dcb912751016"), true, "Södermalm", new Guid("921225c3-3253-470d-8dbf-df1f130dec93") });

            migrationBuilder.InsertData(
                table: "Regions",
                columns: new[] { "Id", "Coastal", "Name", "ParentId" },
                values: new object[] { new Guid("6651afdf-5ada-4cfa-b55d-03ae6d8618d8"), false, "Kista", new Guid("921225c3-3253-470d-8dbf-df1f130dec93") });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("3cfed5d0-0ba6-47d7-8f23-dcb912751016"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("6651afdf-5ada-4cfa-b55d-03ae6d8618d8"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("953a7054-36c8-4a80-897b-52cd16115925"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("921225c3-3253-470d-8dbf-df1f130dec93"));

            migrationBuilder.InsertData(
                table: "Regions",
                columns: new[] { "Id", "Coastal", "Name", "ParentId" },
                values: new object[,]
                {
                    { new Guid("921228c3-3253-470d-8dbf-df1f130dec93"), true, "Stockholm", null },
                    { new Guid("933a7054-36c8-4a80-897b-52cd16115925"), true, "Solna", null },
                    { new Guid("3cfed3d0-0ba6-47d7-8f23-dcb912751016"), true, "Södermalm", null },
                    { new Guid("66c1afdf-5ada-4cfa-b55d-03ae6d8618d8"), false, "Kista", null }
                });
        }
    }
}
