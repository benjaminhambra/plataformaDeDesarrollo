﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Parcial_II.Data;

namespace Parcial_II.Migrations
{
    [DbContext(typeof(TareasDbContext))]
    [Migration("20201114193907_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9");

            modelBuilder.Entity("Parcial_II.Data.Detalles", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<int>("RecursoId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TareaId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Tiempo")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("RecursoId");

                    b.HasIndex("TareaId");

                    b.ToTable("Detalles");
                });

            modelBuilder.Entity("Parcial_II.Data.Recursos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nombre")
                        .HasColumnType("TEXT")
                        .HasMaxLength(50);

                    b.Property<int>("UsuarioId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Recursos");
                });

            modelBuilder.Entity("Parcial_II.Data.Tareas", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Estimacion")
                        .HasColumnType("TEXT");

                    b.Property<int>("RecursoId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ResponsableId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Titulo")
                        .HasColumnType("TEXT");

                    b.Property<string>("Vencimiento")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ResponsableId");

                    b.ToTable("Tareas");
                });

            modelBuilder.Entity("Parcial_II.Data.Usuarios", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Clave")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Usuario")
                        .HasColumnType("TEXT")
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("Parcial_II.Data.Detalles", b =>
                {
                    b.HasOne("Parcial_II.Data.Recursos", "Recurso")
                        .WithMany()
                        .HasForeignKey("RecursoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Parcial_II.Data.Tareas", "Tarea")
                        .WithMany()
                        .HasForeignKey("TareaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Parcial_II.Data.Recursos", b =>
                {
                    b.HasOne("Parcial_II.Data.Usuarios", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Parcial_II.Data.Tareas", b =>
                {
                    b.HasOne("Parcial_II.Data.Recursos", "Responsable")
                        .WithMany()
                        .HasForeignKey("ResponsableId");
                });
#pragma warning restore 612, 618
        }
    }
}