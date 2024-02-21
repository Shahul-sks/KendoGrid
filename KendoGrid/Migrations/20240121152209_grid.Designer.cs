﻿// <auto-generated />
using KendoGrid.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace KendoGrid.Migrations
{
    [DbContext(typeof(EmployeeContext))]
    [Migration("20240121152209_grid")]
    partial class grid
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("KendoGrid.Models.Employee", b =>
                {
                    b.Property<int>("empid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("empid"));

                    b.Property<string>("empaddress")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("empname")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("empsalary")
                        .HasColumnType("integer");

                    b.HasKey("empid");

                    b.ToTable("Employees");
                });
#pragma warning restore 612, 618
        }
    }
}
