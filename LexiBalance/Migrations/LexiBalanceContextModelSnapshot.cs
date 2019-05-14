﻿// <auto-generated />
using LexiBalance.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;

namespace LexiBalance.Migrations
{
    [DbContext(typeof(LexiBalanceContext))]
    partial class LexiBalanceContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity("LexiBalance.Models.Cliente", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CP");

                    b.Property<string>("Nombre")
                        .IsRequired();

                    b.Property<int>("Telefono");

                    b.HasKey("ID");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("LexiBalance.Models.Producto", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Cantidad");

                    b.Property<string>("Caracteristicas")
                        .IsRequired();

                    b.Property<int>("Color");

                    b.Property<string>("Nombre")
                        .IsRequired();

                    b.Property<string>("Precio")
                        .IsRequired();

                    b.HasKey("ID");

                    b.ToTable("Productos");
                });

            modelBuilder.Entity("LexiBalance.Models.Trabajador", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DNI")
                        .IsRequired();

                    b.Property<string>("Direccion")
                        .IsRequired();

                    b.Property<string>("Nombre")
                        .IsRequired();

                    b.Property<int>("Telefono");

                    b.HasKey("ID");

                    b.ToTable("Trabajador");
                });

            modelBuilder.Entity("LexiBalance.Models.Venta", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Cantidad");

                    b.Property<string>("Cliente")
                        .IsRequired();

                    b.Property<DateTime>("Fecha");

                    b.Property<string>("Producto")
                        .IsRequired();

                    b.Property<string>("Trabajador")
                        .IsRequired();

                    b.HasKey("ID");

                    b.ToTable("Venta");
                });
#pragma warning restore 612, 618
        }
    }
}
