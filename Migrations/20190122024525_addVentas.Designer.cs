﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using Sistemadeventa.Models;
using System;

namespace SistemaDeVenta.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20190122024525_addVentas")]
    partial class addVentas
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SistemaDeVenta.Models.Empleado", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Clave");

                    b.Property<string>("Correo");

                    b.Property<string>("Nombre");

                    b.Property<string>("Telefono");

                    b.HasKey("id");

                    b.ToTable("Empleados");
                });

            modelBuilder.Entity("SistemaDeVenta.Models.Producto", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descripcion");

                    b.Property<string>("Nombre");

                    b.Property<string>("Precio");

                    b.HasKey("id");

                    b.ToTable("Productos");
                });

            modelBuilder.Entity("SistemaDeVenta.Models.Venta", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CorreoCliente");

                    b.Property<float>("Precio");

                    b.HasKey("id");

                    b.ToTable("Ventas");
                });
#pragma warning restore 612, 618
        }
    }
}
