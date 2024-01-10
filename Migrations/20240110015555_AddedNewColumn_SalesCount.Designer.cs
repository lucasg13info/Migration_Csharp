﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MigrationStudy.DBContext;

#nullable disable

namespace MigrationStudy.Migrations
{
    [DbContext(typeof(SalesDBContext))]
    [Migration("20240110015555_AddedNewColumn_SalesCount")]
    partial class AddedNewColumn_SalesCount
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("MigrationStudy.DBContext.SalesProducts", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("Varchar(200)")
                        .HasColumnName("ProductName");

                    b.Property<int>("Qty")
                        .HasColumnType("int");

                    b.Property<int>("SalesCount")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("SalesProducts");
                });
#pragma warning restore 612, 618
        }
    }
}
