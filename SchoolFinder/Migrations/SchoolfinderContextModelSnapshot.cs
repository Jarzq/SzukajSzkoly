﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SchoolFinder.Data;

#nullable disable

namespace SchoolFinder.Migrations
{
    [DbContext(typeof(SchoolfinderContext))]
    partial class SchoolfinderContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.26")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("SchoolFinder.models.SchoolEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Dzielnica")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("MaksymalnePunkty")
                        .HasColumnType("float");

                    b.Property<double>("MinimalnePunkty")
                        .HasColumnType("float");

                    b.Property<string>("NazwaOddzialu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NazwaSzkoly")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SchoolType")
                        .HasColumnType("int");

                    b.Property<string>("SymbolOddzialu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SchoolEntities");
                });

            modelBuilder.Entity("SchoolFinder.Models.SchoolEntitySubject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("SchoolEntityId")
                        .HasColumnType("int");

                    b.Property<int>("SubjectId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SchoolEntityId");

                    b.HasIndex("SubjectId");

                    b.ToTable("SchoolEntitySubjects");
                });

            modelBuilder.Entity("SchoolFinder.Models.Subject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Subjects");
                });

            modelBuilder.Entity("SchoolFinder.Models.SchoolEntitySubject", b =>
                {
                    b.HasOne("SchoolFinder.models.SchoolEntity", "SchoolEntity")
                        .WithMany("SchoolEntitySubjects")
                        .HasForeignKey("SchoolEntityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SchoolFinder.Models.Subject", "Subject")
                        .WithMany("SchoolEntitySubjects")
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SchoolEntity");

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("SchoolFinder.models.SchoolEntity", b =>
                {
                    b.Navigation("SchoolEntitySubjects");
                });

            modelBuilder.Entity("SchoolFinder.Models.Subject", b =>
                {
                    b.Navigation("SchoolEntitySubjects");
                });
#pragma warning restore 612, 618
        }
    }
}
