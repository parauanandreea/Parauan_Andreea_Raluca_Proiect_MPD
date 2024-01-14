﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Parauan_Andreea_Raluca_Proiect_MPD.Data;

#nullable disable

namespace Parauan_Andreea_Raluca_Proiect_MPD.Migrations
{
    [DbContext(typeof(Parauan_Andreea_Raluca_Proiect_MPDContext))]
    [Migration("20240114114506_proiectul_depus")]
    partial class proiectul_depus
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.23")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Parauan_Andreea_Raluca_Proiect_MPD.Models.Fondul_Structural", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("FondulStructural")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Fondul_Structural");
                });

            modelBuilder.Entity("Parauan_Andreea_Raluca_Proiect_MPD.Models.Proiect_depus", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Proiectul_a_fost_depus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Proiect_depus");
                });

            modelBuilder.Entity("Parauan_Andreea_Raluca_Proiect_MPD.Models.Proiect_MPD", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Cod_apel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Data_publicarii_ghidului")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Fondul_StructuralID")
                        .HasColumnType("int");

                    b.Property<int?>("Proiect_depusID")
                        .HasColumnType("int");

                    b.Property<string>("Regiunea_de_dezvoltare")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Tip_ajutorID")
                        .HasColumnType("int");

                    b.Property<string>("Tip_apel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Titlu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("Fondul_StructuralID");

                    b.HasIndex("Proiect_depusID");

                    b.HasIndex("Tip_ajutorID");

                    b.ToTable("Proiect_MPD");
                });

            modelBuilder.Entity("Parauan_Andreea_Raluca_Proiect_MPD.Models.Tip_ajutor", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Tipul_ajutor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Tip_ajutor");
                });

            modelBuilder.Entity("Parauan_Andreea_Raluca_Proiect_MPD.Models.Proiect_MPD", b =>
                {
                    b.HasOne("Parauan_Andreea_Raluca_Proiect_MPD.Models.Fondul_Structural", "Fondul_Structural")
                        .WithMany()
                        .HasForeignKey("Fondul_StructuralID");

                    b.HasOne("Parauan_Andreea_Raluca_Proiect_MPD.Models.Proiect_depus", "Proiect_depus")
                        .WithMany()
                        .HasForeignKey("Proiect_depusID");

                    b.HasOne("Parauan_Andreea_Raluca_Proiect_MPD.Models.Tip_ajutor", "Tip_ajutor")
                        .WithMany()
                        .HasForeignKey("Tip_ajutorID");

                    b.Navigation("Fondul_Structural");

                    b.Navigation("Proiect_depus");

                    b.Navigation("Tip_ajutor");
                });
#pragma warning restore 612, 618
        }
    }
}
