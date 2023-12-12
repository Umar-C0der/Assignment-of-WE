﻿// <auto-generated />
using Assignment.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Assignment.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231212072042_initialcreate")]
    partial class initialcreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Assignment.Data.Class", b =>
                {
                    b.Property<int>("Cid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Cid"));

                    b.Property<int>("FacultyFid")
                        .HasColumnType("int");

                    b.Property<int>("Fid")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoomNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Cid");

                    b.HasIndex("FacultyFid");

                    b.ToTable("Classes");
                });

            modelBuilder.Entity("Assignment.Data.Enrolled", b =>
                {
                    b.Property<int>("EnrollmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EnrollmentId"));

                    b.Property<int>("Cid")
                        .HasColumnType("int");

                    b.Property<int>("ClassCid")
                        .HasColumnType("int");

                    b.Property<int>("Sid")
                        .HasColumnType("int");

                    b.Property<int>("StudentSid")
                        .HasColumnType("int");

                    b.HasKey("EnrollmentId");

                    b.HasIndex("ClassCid");

                    b.HasIndex("StudentSid");

                    b.ToTable("Enrollments");
                });

            modelBuilder.Entity("Assignment.Data.Faculty", b =>
                {
                    b.Property<int>("Fid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Fid"));

                    b.Property<string>("Deptid")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Standing")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Fid");

                    b.ToTable("Faculties");
                });

            modelBuilder.Entity("Assignment.Data.Student", b =>
                {
                    b.Property<int>("Sid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Sid"));

                    b.Property<string>("Major")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Standing")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Sid");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("Assignment.Data.Class", b =>
                {
                    b.HasOne("Assignment.Data.Faculty", "Faculty")
                        .WithMany("Classes")
                        .HasForeignKey("FacultyFid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Faculty");
                });

            modelBuilder.Entity("Assignment.Data.Enrolled", b =>
                {
                    b.HasOne("Assignment.Data.Class", "Class")
                        .WithMany("Enrollments")
                        .HasForeignKey("ClassCid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Assignment.Data.Student", "Student")
                        .WithMany("Enrollments")
                        .HasForeignKey("StudentSid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Class");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("Assignment.Data.Class", b =>
                {
                    b.Navigation("Enrollments");
                });

            modelBuilder.Entity("Assignment.Data.Faculty", b =>
                {
                    b.Navigation("Classes");
                });

            modelBuilder.Entity("Assignment.Data.Student", b =>
                {
                    b.Navigation("Enrollments");
                });
#pragma warning restore 612, 618
        }
    }
}