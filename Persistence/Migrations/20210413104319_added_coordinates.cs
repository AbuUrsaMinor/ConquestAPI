using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class added_coordinates : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Coordinates",
                columns: new[] { "Id", "Latitude", "Longitude" },
                values: new object[,]
                {
                    { new Guid("602bba97-12ab-4736-bc7d-412e07c07aab"), 59.392201307280892, 17.948989244576598 },
                    { new Guid("bf75248e-7a70-4b21-9164-2d70b688b835"), 59.405281204497768, 17.922717647457233 },
                    { new Guid("b19dfc33-ee99-4c5b-ae6d-276c1ca937ef"), 59.414243162108527, 17.940039579623843 },
                    { new Guid("225ee1ce-db68-4b9c-94c0-4cfc35948782"), 59.398447955435387, 17.97641563717373 },
                    { new Guid("0a5f126d-9997-4daf-8020-345934d284cd"), 59.466436319594088, 18.487921300999744 },
                    { new Guid("053411fe-6184-4d24-90ba-a22dc30169d3"), 59.077073334135257, 18.474954897944063 },
                    { new Guid("990e250a-0f0c-455e-9162-636ce33fe346"), 59.178223876567699, 17.709756952714102 },
                    { new Guid("cefa7d5e-c6a2-447d-97a0-5f29343b3c15"), 59.386468075079208, 17.975260842170009 },
                    { new Guid("7db52c29-547f-4c68-bd11-c298520af633"), 59.37213075392674, 18.037186749665644 },
                    { new Guid("ec607af0-3d97-4dec-85bf-153b9d114b92"), 59.351018130519869, 18.051621693137822 },
                    { new Guid("0dd216c9-ca94-4b3b-8e20-e75ab7a87a93"), 59.348442521712613, 17.975116492735285 },
                    { new Guid("2bc8c8eb-73ef-4cd8-99ec-c366f2077f63"), 59.323191213252372, 18.02506139796964 },
                    { new Guid("746a5c3d-f239-41a0-83f8-dcc9a74f8636"), 59.317298995689818, 18.109361467847151 },
                    { new Guid("ffe63975-16bf-4252-b5a1-5a8501d53cc9"), 59.302195525730475, 18.076161097861142 },
                    { new Guid("ea93b9c7-9621-4e03-9aec-8cb1ad1b8094"), 59.315383805064968, 18.023762253057146 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Coordinates",
                keyColumn: "Id",
                keyValue: new Guid("053411fe-6184-4d24-90ba-a22dc30169d3"));

            migrationBuilder.DeleteData(
                table: "Coordinates",
                keyColumn: "Id",
                keyValue: new Guid("0a5f126d-9997-4daf-8020-345934d284cd"));

            migrationBuilder.DeleteData(
                table: "Coordinates",
                keyColumn: "Id",
                keyValue: new Guid("0dd216c9-ca94-4b3b-8e20-e75ab7a87a93"));

            migrationBuilder.DeleteData(
                table: "Coordinates",
                keyColumn: "Id",
                keyValue: new Guid("225ee1ce-db68-4b9c-94c0-4cfc35948782"));

            migrationBuilder.DeleteData(
                table: "Coordinates",
                keyColumn: "Id",
                keyValue: new Guid("2bc8c8eb-73ef-4cd8-99ec-c366f2077f63"));

            migrationBuilder.DeleteData(
                table: "Coordinates",
                keyColumn: "Id",
                keyValue: new Guid("602bba97-12ab-4736-bc7d-412e07c07aab"));

            migrationBuilder.DeleteData(
                table: "Coordinates",
                keyColumn: "Id",
                keyValue: new Guid("746a5c3d-f239-41a0-83f8-dcc9a74f8636"));

            migrationBuilder.DeleteData(
                table: "Coordinates",
                keyColumn: "Id",
                keyValue: new Guid("7db52c29-547f-4c68-bd11-c298520af633"));

            migrationBuilder.DeleteData(
                table: "Coordinates",
                keyColumn: "Id",
                keyValue: new Guid("990e250a-0f0c-455e-9162-636ce33fe346"));

            migrationBuilder.DeleteData(
                table: "Coordinates",
                keyColumn: "Id",
                keyValue: new Guid("b19dfc33-ee99-4c5b-ae6d-276c1ca937ef"));

            migrationBuilder.DeleteData(
                table: "Coordinates",
                keyColumn: "Id",
                keyValue: new Guid("bf75248e-7a70-4b21-9164-2d70b688b835"));

            migrationBuilder.DeleteData(
                table: "Coordinates",
                keyColumn: "Id",
                keyValue: new Guid("cefa7d5e-c6a2-447d-97a0-5f29343b3c15"));

            migrationBuilder.DeleteData(
                table: "Coordinates",
                keyColumn: "Id",
                keyValue: new Guid("ea93b9c7-9621-4e03-9aec-8cb1ad1b8094"));

            migrationBuilder.DeleteData(
                table: "Coordinates",
                keyColumn: "Id",
                keyValue: new Guid("ec607af0-3d97-4dec-85bf-153b9d114b92"));

            migrationBuilder.DeleteData(
                table: "Coordinates",
                keyColumn: "Id",
                keyValue: new Guid("ffe63975-16bf-4252-b5a1-5a8501d53cc9"));
        }
    }
}
