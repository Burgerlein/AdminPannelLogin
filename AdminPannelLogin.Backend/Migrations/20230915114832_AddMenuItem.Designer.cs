﻿// <auto-generated />
using AdminPannelLogin.Backend.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AdminPannelLogin.Backend.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230915114832_AddMenuItem")]
    partial class AddMenuItem
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("AdminPannelLogin.Backend.Entities.MenuItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("DescriptionDe")
                        .HasColumnType("longtext");

                    b.Property<string>("DescriptionEn")
                        .HasColumnType("longtext");

                    b.Property<string>("NameDe")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("NameEn")
                        .HasColumnType("longtext");

                    b.Property<double>("Price")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.ToTable("MenuItems");
                });
#pragma warning restore 612, 618
        }
    }
}
