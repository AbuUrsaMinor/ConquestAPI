using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class added_more_region_coordinates : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "RegionCoordinates",
                columns: new[] { "CoordinateId", "RegionId" },
                values: new object[,]
                {
                    { new Guid("0a5f126d-9997-4daf-8020-345934d284cd"), new Guid("921225c3-3253-470d-8dbf-df1f130dec93") },
                    { new Guid("053411fe-6184-4d24-90ba-a22dc30169d3"), new Guid("921225c3-3253-470d-8dbf-df1f130dec93") },
                    { new Guid("990e250a-0f0c-455e-9162-636ce33fe346"), new Guid("921225c3-3253-470d-8dbf-df1f130dec93") },
                    { new Guid("cefa7d5e-c6a2-447d-97a0-5f29343b3c15"), new Guid("953a7054-36c8-4a80-897b-52cd16115925") },
                    { new Guid("7db52c29-547f-4c68-bd11-c298520af633"), new Guid("953a7054-36c8-4a80-897b-52cd16115925") },
                    { new Guid("ec607af0-3d97-4dec-85bf-153b9d114b92"), new Guid("953a7054-36c8-4a80-897b-52cd16115925") },
                    { new Guid("0dd216c9-ca94-4b3b-8e20-e75ab7a87a93"), new Guid("953a7054-36c8-4a80-897b-52cd16115925") },
                    { new Guid("2bc8c8eb-73ef-4cd8-99ec-c366f2077f63"), new Guid("3cfed5d0-0ba6-47d7-8f23-dcb912751016") },
                    { new Guid("746a5c3d-f239-41a0-83f8-dcc9a74f8636"), new Guid("3cfed5d0-0ba6-47d7-8f23-dcb912751016") },
                    { new Guid("ffe63975-16bf-4252-b5a1-5a8501d53cc9"), new Guid("3cfed5d0-0ba6-47d7-8f23-dcb912751016") },
                    { new Guid("ea93b9c7-9621-4e03-9aec-8cb1ad1b8094"), new Guid("3cfed5d0-0ba6-47d7-8f23-dcb912751016") },
                    { new Guid("602bba97-12ab-4736-bc7d-412e07c07aab"), new Guid("6651afdf-5ada-4cfa-b55d-03ae6d8618d8") },
                    { new Guid("bf75248e-7a70-4b21-9164-2d70b688b835"), new Guid("6651afdf-5ada-4cfa-b55d-03ae6d8618d8") },
                    { new Guid("b19dfc33-ee99-4c5b-ae6d-276c1ca937ef"), new Guid("6651afdf-5ada-4cfa-b55d-03ae6d8618d8") },
                    { new Guid("225ee1ce-db68-4b9c-94c0-4cfc35948782"), new Guid("6651afdf-5ada-4cfa-b55d-03ae6d8618d8") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RegionCoordinates",
                keyColumns: new[] { "CoordinateId", "RegionId" },
                keyValues: new object[] { new Guid("2bc8c8eb-73ef-4cd8-99ec-c366f2077f63"), new Guid("3cfed5d0-0ba6-47d7-8f23-dcb912751016") });

            migrationBuilder.DeleteData(
                table: "RegionCoordinates",
                keyColumns: new[] { "CoordinateId", "RegionId" },
                keyValues: new object[] { new Guid("746a5c3d-f239-41a0-83f8-dcc9a74f8636"), new Guid("3cfed5d0-0ba6-47d7-8f23-dcb912751016") });

            migrationBuilder.DeleteData(
                table: "RegionCoordinates",
                keyColumns: new[] { "CoordinateId", "RegionId" },
                keyValues: new object[] { new Guid("ea93b9c7-9621-4e03-9aec-8cb1ad1b8094"), new Guid("3cfed5d0-0ba6-47d7-8f23-dcb912751016") });

            migrationBuilder.DeleteData(
                table: "RegionCoordinates",
                keyColumns: new[] { "CoordinateId", "RegionId" },
                keyValues: new object[] { new Guid("ffe63975-16bf-4252-b5a1-5a8501d53cc9"), new Guid("3cfed5d0-0ba6-47d7-8f23-dcb912751016") });

            migrationBuilder.DeleteData(
                table: "RegionCoordinates",
                keyColumns: new[] { "CoordinateId", "RegionId" },
                keyValues: new object[] { new Guid("225ee1ce-db68-4b9c-94c0-4cfc35948782"), new Guid("6651afdf-5ada-4cfa-b55d-03ae6d8618d8") });

            migrationBuilder.DeleteData(
                table: "RegionCoordinates",
                keyColumns: new[] { "CoordinateId", "RegionId" },
                keyValues: new object[] { new Guid("602bba97-12ab-4736-bc7d-412e07c07aab"), new Guid("6651afdf-5ada-4cfa-b55d-03ae6d8618d8") });

            migrationBuilder.DeleteData(
                table: "RegionCoordinates",
                keyColumns: new[] { "CoordinateId", "RegionId" },
                keyValues: new object[] { new Guid("b19dfc33-ee99-4c5b-ae6d-276c1ca937ef"), new Guid("6651afdf-5ada-4cfa-b55d-03ae6d8618d8") });

            migrationBuilder.DeleteData(
                table: "RegionCoordinates",
                keyColumns: new[] { "CoordinateId", "RegionId" },
                keyValues: new object[] { new Guid("bf75248e-7a70-4b21-9164-2d70b688b835"), new Guid("6651afdf-5ada-4cfa-b55d-03ae6d8618d8") });

            migrationBuilder.DeleteData(
                table: "RegionCoordinates",
                keyColumns: new[] { "CoordinateId", "RegionId" },
                keyValues: new object[] { new Guid("053411fe-6184-4d24-90ba-a22dc30169d3"), new Guid("921225c3-3253-470d-8dbf-df1f130dec93") });

            migrationBuilder.DeleteData(
                table: "RegionCoordinates",
                keyColumns: new[] { "CoordinateId", "RegionId" },
                keyValues: new object[] { new Guid("0a5f126d-9997-4daf-8020-345934d284cd"), new Guid("921225c3-3253-470d-8dbf-df1f130dec93") });

            migrationBuilder.DeleteData(
                table: "RegionCoordinates",
                keyColumns: new[] { "CoordinateId", "RegionId" },
                keyValues: new object[] { new Guid("990e250a-0f0c-455e-9162-636ce33fe346"), new Guid("921225c3-3253-470d-8dbf-df1f130dec93") });

            migrationBuilder.DeleteData(
                table: "RegionCoordinates",
                keyColumns: new[] { "CoordinateId", "RegionId" },
                keyValues: new object[] { new Guid("0dd216c9-ca94-4b3b-8e20-e75ab7a87a93"), new Guid("953a7054-36c8-4a80-897b-52cd16115925") });

            migrationBuilder.DeleteData(
                table: "RegionCoordinates",
                keyColumns: new[] { "CoordinateId", "RegionId" },
                keyValues: new object[] { new Guid("7db52c29-547f-4c68-bd11-c298520af633"), new Guid("953a7054-36c8-4a80-897b-52cd16115925") });

            migrationBuilder.DeleteData(
                table: "RegionCoordinates",
                keyColumns: new[] { "CoordinateId", "RegionId" },
                keyValues: new object[] { new Guid("cefa7d5e-c6a2-447d-97a0-5f29343b3c15"), new Guid("953a7054-36c8-4a80-897b-52cd16115925") });

            migrationBuilder.DeleteData(
                table: "RegionCoordinates",
                keyColumns: new[] { "CoordinateId", "RegionId" },
                keyValues: new object[] { new Guid("ec607af0-3d97-4dec-85bf-153b9d114b92"), new Guid("953a7054-36c8-4a80-897b-52cd16115925") });
        }
    }
}
