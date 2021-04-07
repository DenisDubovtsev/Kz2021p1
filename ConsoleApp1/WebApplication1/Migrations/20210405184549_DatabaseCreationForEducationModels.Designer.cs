﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication1.EfStuff;

namespace WebApplication1.Migrations
{
    [DbContext(typeof(KzDbContext))]
    [Migration("20210405184549_DatabaseCreationForEducationModels")]
    partial class DatabaseCreationForEducationModels
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CertificatePupil", b =>
                {
                    b.Property<long>("CertificatesId")
                        .HasColumnType("bigint");

                    b.Property<long>("PupilsId")
                        .HasColumnType("bigint");

                    b.HasKey("CertificatesId", "PupilsId");

                    b.HasIndex("PupilsId");

                    b.ToTable("CertificatePupil");
                });

            modelBuilder.Entity("CertificateStudent", b =>
                {
                    b.Property<long>("CertificatesId")
                        .HasColumnType("bigint");

                    b.Property<long>("StudentsId")
                        .HasColumnType("bigint");

                    b.HasKey("CertificatesId", "StudentsId");

                    b.HasIndex("StudentsId");

                    b.ToTable("CertificateStudent");
                });

            modelBuilder.Entity("WebApplication1.EfStuff.Model.Adress", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("FloorCount")
                        .HasColumnType("int");

                    b.Property<int>("HouseNumber")
                        .HasColumnType("int");

                    b.Property<string>("Street")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Adress");
                });

            modelBuilder.Entity("WebApplication1.EfStuff.Model.Certificate", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Certificates");
                });

            modelBuilder.Entity("WebApplication1.EfStuff.Model.Citizen", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatingDate")
                        .HasColumnType("datetime2");

                    b.Property<long?>("HouseId")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("HouseId");

                    b.ToTable("Citizens");
                });

            modelBuilder.Entity("WebApplication1.EfStuff.Model.Pupil", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("AverageMark")
                        .HasColumnType("float");

                    b.Property<string>("Birthday")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ClassYear")
                        .HasColumnType("int");

                    b.Property<int?>("ENT")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<DateTime?>("GraduatedYear")
                        .HasColumnType("datetime2");

                    b.Property<string>("IIN")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Patronymic")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<long>("SchoolId")
                        .HasColumnType("bigint");

                    b.Property<string>("Subject")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.HasIndex("SchoolId");

                    b.ToTable("Pupils");
                });

            modelBuilder.Entity("WebApplication1.EfStuff.Model.School", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Description")
                        .HasMaxLength(2000)
                        .HasColumnType("nvarchar(2000)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Schools");
                });

            modelBuilder.Entity("WebApplication1.EfStuff.Model.Student", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Birthday")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CourseYear")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<DateTime>("EnteredYear")
                        .HasColumnType("datetime2");

                    b.Property<string>("Faculty")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<double>("Gpa")
                        .HasColumnType("float");

                    b.Property<DateTime?>("GraduatedYear")
                        .HasColumnType("datetime2");

                    b.Property<string>("IIN")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<bool>("OnGrant")
                        .HasColumnType("bit");

                    b.Property<string>("Patronymic")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<long>("UniversityId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("UniversityId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("WebApplication1.EfStuff.Model.University", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Description")
                        .HasMaxLength(2000)
                        .HasColumnType("nvarchar(2000)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Universities");
                });

            modelBuilder.Entity("CertificatePupil", b =>
                {
                    b.HasOne("WebApplication1.EfStuff.Model.Certificate", null)
                        .WithMany()
                        .HasForeignKey("CertificatesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApplication1.EfStuff.Model.Pupil", null)
                        .WithMany()
                        .HasForeignKey("PupilsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CertificateStudent", b =>
                {
                    b.HasOne("WebApplication1.EfStuff.Model.Certificate", null)
                        .WithMany()
                        .HasForeignKey("CertificatesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApplication1.EfStuff.Model.Student", null)
                        .WithMany()
                        .HasForeignKey("StudentsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WebApplication1.EfStuff.Model.Citizen", b =>
                {
                    b.HasOne("WebApplication1.EfStuff.Model.Adress", "House")
                        .WithMany("Citizens")
                        .HasForeignKey("HouseId");

                    b.Navigation("House");
                });

            modelBuilder.Entity("WebApplication1.EfStuff.Model.Pupil", b =>
                {
                    b.HasOne("WebApplication1.EfStuff.Model.School", "School")
                        .WithMany("Pupils")
                        .HasForeignKey("SchoolId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("School");
                });

            modelBuilder.Entity("WebApplication1.EfStuff.Model.Student", b =>
                {
                    b.HasOne("WebApplication1.EfStuff.Model.University", "University")
                        .WithMany("Students")
                        .HasForeignKey("UniversityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("University");
                });

            modelBuilder.Entity("WebApplication1.EfStuff.Model.Adress", b =>
                {
                    b.Navigation("Citizens");
                });

            modelBuilder.Entity("WebApplication1.EfStuff.Model.School", b =>
                {
                    b.Navigation("Pupils");
                });

            modelBuilder.Entity("WebApplication1.EfStuff.Model.University", b =>
                {
                    b.Navigation("Students");
                });
#pragma warning restore 612, 618
        }
    }
}