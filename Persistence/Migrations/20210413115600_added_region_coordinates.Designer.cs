// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistence.Db;

namespace Persistence.Migrations
{
    [DbContext(typeof(ConquestDbContext))]
    [Migration("20210413115600_added_region_coordinates")]
    partial class added_region_coordinates
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Domain.Entities.Coordinate", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("Latitude")
                        .HasColumnType("float");

                    b.Property<double>("Longitude")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Coordinates");

                    b.HasData(
                        new
                        {
                            Id = new Guid("602bba97-12ab-4736-bc7d-412e07c07aab"),
                            Latitude = 59.392201307280892,
                            Longitude = 17.948989244576598
                        },
                        new
                        {
                            Id = new Guid("bf75248e-7a70-4b21-9164-2d70b688b835"),
                            Latitude = 59.405281204497768,
                            Longitude = 17.922717647457233
                        },
                        new
                        {
                            Id = new Guid("b19dfc33-ee99-4c5b-ae6d-276c1ca937ef"),
                            Latitude = 59.414243162108527,
                            Longitude = 17.940039579623843
                        },
                        new
                        {
                            Id = new Guid("225ee1ce-db68-4b9c-94c0-4cfc35948782"),
                            Latitude = 59.398447955435387,
                            Longitude = 17.97641563717373
                        },
                        new
                        {
                            Id = new Guid("90774271-f4c5-409d-b51c-b02c9e2b781f"),
                            Latitude = 59.477946258806533,
                            Longitude = 17.787542935493313
                        },
                        new
                        {
                            Id = new Guid("0a5f126d-9997-4daf-8020-345934d284cd"),
                            Latitude = 59.466436319594088,
                            Longitude = 18.487921300999744
                        },
                        new
                        {
                            Id = new Guid("053411fe-6184-4d24-90ba-a22dc30169d3"),
                            Latitude = 59.077073334135257,
                            Longitude = 18.474954897944063
                        },
                        new
                        {
                            Id = new Guid("990e250a-0f0c-455e-9162-636ce33fe346"),
                            Latitude = 59.178223876567699,
                            Longitude = 17.709756952714102
                        },
                        new
                        {
                            Id = new Guid("cefa7d5e-c6a2-447d-97a0-5f29343b3c15"),
                            Latitude = 59.386468075079208,
                            Longitude = 17.975260842170009
                        },
                        new
                        {
                            Id = new Guid("7db52c29-547f-4c68-bd11-c298520af633"),
                            Latitude = 59.37213075392674,
                            Longitude = 18.037186749665644
                        },
                        new
                        {
                            Id = new Guid("ec607af0-3d97-4dec-85bf-153b9d114b92"),
                            Latitude = 59.351018130519869,
                            Longitude = 18.051621693137822
                        },
                        new
                        {
                            Id = new Guid("0dd216c9-ca94-4b3b-8e20-e75ab7a87a93"),
                            Latitude = 59.348442521712613,
                            Longitude = 17.975116492735285
                        },
                        new
                        {
                            Id = new Guid("2bc8c8eb-73ef-4cd8-99ec-c366f2077f63"),
                            Latitude = 59.323191213252372,
                            Longitude = 18.02506139796964
                        },
                        new
                        {
                            Id = new Guid("746a5c3d-f239-41a0-83f8-dcc9a74f8636"),
                            Latitude = 59.317298995689818,
                            Longitude = 18.109361467847151
                        },
                        new
                        {
                            Id = new Guid("ffe63975-16bf-4252-b5a1-5a8501d53cc9"),
                            Latitude = 59.302195525730475,
                            Longitude = 18.076161097861142
                        },
                        new
                        {
                            Id = new Guid("ea93b9c7-9621-4e03-9aec-8cb1ad1b8094"),
                            Latitude = 59.315383805064968,
                            Longitude = 18.023762253057146
                        });
                });

            modelBuilder.Entity("Domain.Entities.Region", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Coastal")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("ParentId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ParentId");

                    b.ToTable("Regions");

                    b.HasData(
                        new
                        {
                            Id = new Guid("921225c3-3253-470d-8dbf-df1f130dec93"),
                            Coastal = true,
                            Name = "Stockholm"
                        },
                        new
                        {
                            Id = new Guid("953a7054-36c8-4a80-897b-52cd16115925"),
                            Coastal = true,
                            Name = "Solna",
                            ParentId = new Guid("921225c3-3253-470d-8dbf-df1f130dec93")
                        },
                        new
                        {
                            Id = new Guid("3cfed5d0-0ba6-47d7-8f23-dcb912751016"),
                            Coastal = true,
                            Name = "Södermalm",
                            ParentId = new Guid("921225c3-3253-470d-8dbf-df1f130dec93")
                        },
                        new
                        {
                            Id = new Guid("6651afdf-5ada-4cfa-b55d-03ae6d8618d8"),
                            Coastal = false,
                            Name = "Kista",
                            ParentId = new Guid("921225c3-3253-470d-8dbf-df1f130dec93")
                        });
                });

            modelBuilder.Entity("Domain.Entities.RegionCoordinate", b =>
                {
                    b.Property<Guid>("RegionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CoordinateId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("RegionId", "CoordinateId");

                    b.HasIndex("CoordinateId");

                    b.ToTable("RegionCoordinates");

                    b.HasData(
                        new
                        {
                            RegionId = new Guid("921225c3-3253-470d-8dbf-df1f130dec93"),
                            CoordinateId = new Guid("90774271-f4c5-409d-b51c-b02c9e2b781f")
                        });
                });

            modelBuilder.Entity("Domain.Entities.Region", b =>
                {
                    b.HasOne("Domain.Entities.Region", "Parent")
                        .WithMany()
                        .HasForeignKey("ParentId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("Parent");
                });

            modelBuilder.Entity("Domain.Entities.RegionCoordinate", b =>
                {
                    b.HasOne("Domain.Entities.Coordinate", null)
                        .WithMany()
                        .HasForeignKey("CoordinateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Region", null)
                        .WithMany("Coordinates")
                        .HasForeignKey("RegionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Entities.Region", b =>
                {
                    b.Navigation("Coordinates");
                });
#pragma warning restore 612, 618
        }
    }
}
