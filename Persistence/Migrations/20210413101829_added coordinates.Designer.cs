﻿// <auto-generated />
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
    [Migration("20210413101829_added coordinates")]
    partial class addedcoordinates
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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

            modelBuilder.Entity("Domain.Entities.Region", b =>
                {
                    b.HasOne("Domain.Entities.Region", "Parent")
                        .WithMany()
                        .HasForeignKey("ParentId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("Parent");
                });
#pragma warning restore 612, 618
        }
    }
}
