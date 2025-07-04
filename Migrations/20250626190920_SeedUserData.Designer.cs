﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OmintakProduction.Data;

#nullable disable

namespace OmintakProduction.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20250626190920_SeedUserData")]
    partial class SeedUserData
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("OmintakProduction.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<DateOnly>("CreatedDate")
                        .HasColumnType("date");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("User");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            CreatedDate = new DateOnly(2025, 6, 26),
                            Email = "Admin@omnitak.com",
                            Password = "Admin@123",
                            RoleId = "1",
                            Status = "Active",
                            UserName = "AdminUser"
                        },
                        new
                        {
                            UserId = 2,
                            CreatedDate = new DateOnly(2025, 6, 26),
                            Email = "Engineer@omnitak.com",
                            Password = "Engineer@123",
                            RoleId = "2",
                            Status = "Active",
                            UserName = "EngineerUser"
                        },
                        new
                        {
                            UserId = 3,
                            CreatedDate = new DateOnly(2025, 6, 26),
                            Email = "Tester@omnitak.com",
                            Password = "Tester@123",
                            RoleId = "3",
                            Status = "Active",
                            UserName = "TesterUser"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
