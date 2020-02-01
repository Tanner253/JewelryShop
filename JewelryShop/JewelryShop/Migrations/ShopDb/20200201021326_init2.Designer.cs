﻿// <auto-generated />
using JewelryShop.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace JewelryShop.Migrations.ShopDb
{
    [DbContext(typeof(ShopDbContext))]
    [Migration("20200201021326_init2")]
    partial class init2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("JewelryShop.Models.JewelryItem", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<string>("InStock");

                    b.Property<string>("Name");

                    b.Property<string>("Picture1");

                    b.Property<string>("Picture2");

                    b.Property<string>("Picture3");

                    b.Property<string>("Price");

                    b.HasKey("ID");

                    b.ToTable("JewelryItem");
                });
#pragma warning restore 612, 618
        }
    }
}