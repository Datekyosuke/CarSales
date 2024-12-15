﻿// <auto-generated />
using System;
using CarSale.DAL.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CarSale.DAL.Migrations
{
    [DbContext(typeof(CarSalesDB))]
    partial class CarSalesDBModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CarSale.DAL.Entities.Brand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Brands");
                });

            modelBuilder.Entity("CarSale.DAL.Entities.Car", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ConfigurationId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ConfigurationId");

                    b.ToTable("Cars");
                });

            modelBuilder.Entity("CarSale.DAL.Entities.Configuration", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ModelId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("ModelId");

                    b.ToTable("Configurations");
                });

            modelBuilder.Entity("CarSale.DAL.Entities.Model", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BrandId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.ToTable("Models");
                });

            modelBuilder.Entity("CarSale.DAL.Entities.Sale", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CarsId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<DateTime>("SaleDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("CarsId");

                    b.ToTable("Sales");
                });

            modelBuilder.Entity("CarSale.DAL.Entities.Car", b =>
                {
                    b.HasOne("CarSale.DAL.Entities.Configuration", "Configuration")
                        .WithMany("Cars")
                        .HasForeignKey("ConfigurationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Configuration");
                });

            modelBuilder.Entity("CarSale.DAL.Entities.Configuration", b =>
                {
                    b.HasOne("CarSale.DAL.Entities.Model", "Model")
                        .WithMany("Configurations")
                        .HasForeignKey("ModelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Model");
                });

            modelBuilder.Entity("CarSale.DAL.Entities.Model", b =>
                {
                    b.HasOne("CarSale.DAL.Entities.Brand", "Brand")
                        .WithMany("Models")
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Brand");
                });

            modelBuilder.Entity("CarSale.DAL.Entities.Sale", b =>
                {
                    b.HasOne("CarSale.DAL.Entities.Car", "Cars")
                        .WithMany("Sales")
                        .HasForeignKey("CarsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cars");
                });

            modelBuilder.Entity("CarSale.DAL.Entities.Brand", b =>
                {
                    b.Navigation("Models");
                });

            modelBuilder.Entity("CarSale.DAL.Entities.Car", b =>
                {
                    b.Navigation("Sales");
                });

            modelBuilder.Entity("CarSale.DAL.Entities.Configuration", b =>
                {
                    b.Navigation("Cars");
                });

            modelBuilder.Entity("CarSale.DAL.Entities.Model", b =>
                {
                    b.Navigation("Configurations");
                });
#pragma warning restore 612, 618
        }
    }
}
