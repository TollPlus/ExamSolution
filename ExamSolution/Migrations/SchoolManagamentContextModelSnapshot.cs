﻿// <auto-generated />
using System;
using ExamSolution.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ExamSolution.Migrations
{
    [DbContext(typeof(SchoolManagamentContext))]
    partial class SchoolManagamentContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ExamSolution.Models.ClassDetailsModel", b =>
                {
                    b.Property<int>("ClassId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Standard")
                        .HasColumnType("int");

                    b.HasKey("ClassId");

                    b.ToTable("ClassDetails");
                });

            modelBuilder.Entity("ExamSolution.Models.StudentModelClass", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ClassDetailsModelClassId")
                        .HasColumnType("int");

                    b.Property<int>("ClassId")
                        .HasColumnType("int");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("Grade")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("Section")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StudentName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StudentId");

                    b.HasIndex("ClassDetailsModelClassId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("ExamSolution.Models.TeacherModelClass", b =>
                {
                    b.Property<int>("TeacherId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ClassDetailsModelClassId")
                        .HasColumnType("int");

                    b.Property<int>("ClassId")
                        .HasColumnType("int");

                    b.Property<string>("Subject")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TeacherName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TeacherId");

                    b.HasIndex("ClassDetailsModelClassId");

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("ExamSolution.Models.StudentModelClass", b =>
                {
                    b.HasOne("ExamSolution.Models.ClassDetailsModel", "ClassDetailsModel")
                        .WithMany()
                        .HasForeignKey("ClassDetailsModelClassId");
                });

            modelBuilder.Entity("ExamSolution.Models.TeacherModelClass", b =>
                {
                    b.HasOne("ExamSolution.Models.ClassDetailsModel", "ClassDetailsModel")
                        .WithMany()
                        .HasForeignKey("ClassDetailsModelClassId");
                });
#pragma warning restore 612, 618
        }
    }
}
