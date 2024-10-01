﻿// <auto-generated />
using System;
using ITIAcademy.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ITIAcademy.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20241001175719_InsertSectionsAndSchedules")]
    partial class InsertSectionsAndSchedules
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ITIAcademy.Models.Course", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("CourseName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("VARCHAR");

                    b.HasKey("Id");

                    b.ToTable("Courses", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CourseName = "Introduction to Computer Science"
                        },
                        new
                        {
                            Id = 2,
                            CourseName = "Web Development Fundamentals"
                        },
                        new
                        {
                            Id = 3,
                            CourseName = "Artificial Intelligence"
                        },
                        new
                        {
                            Id = 4,
                            CourseName = "Machine Learning Techniques"
                        },
                        new
                        {
                            Id = 5,
                            CourseName = "Software Engineering Principles"
                        },
                        new
                        {
                            Id = 6,
                            CourseName = "Cybersecurity Basics"
                        },
                        new
                        {
                            Id = 7,
                            CourseName = "Cloud Computing with Azure"
                        },
                        new
                        {
                            Id = 8,
                            CourseName = "Database Management Systems"
                        },
                        new
                        {
                            Id = 9,
                            CourseName = "Data Structures and Algorithms"
                        },
                        new
                        {
                            Id = 10,
                            CourseName = "Mobile App Development with Flutter"
                        });
                });

            modelBuilder.Entity("ITIAcademy.Models.Instructor", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("FName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("VARCHAR");

                    b.Property<string>("LName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("VARCHAR");

                    b.HasKey("Id");

                    b.ToTable("Instructors", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FName = "Ahmed",
                            LName = "Abdullah"
                        },
                        new
                        {
                            Id = 2,
                            FName = "Yasmeen",
                            LName = "Mohamed"
                        },
                        new
                        {
                            Id = 3,
                            FName = "Khalid",
                            LName = "Hassan"
                        },
                        new
                        {
                            Id = 4,
                            FName = "Nadia",
                            LName = "Ali"
                        },
                        new
                        {
                            Id = 5,
                            FName = "Aya",
                            LName = "Abdullah"
                        },
                        new
                        {
                            Id = 6,
                            FName = "Ahmed",
                            LName = "Atef"
                        },
                        new
                        {
                            Id = 7,
                            FName = "ALi",
                            LName = "Saad"
                        },
                        new
                        {
                            Id = 8,
                            FName = "Essam",
                            LName = "Abo"
                        },
                        new
                        {
                            Id = 9,
                            FName = "Hamza",
                            LName = "Ahmed"
                        },
                        new
                        {
                            Id = 10,
                            FName = "Malak",
                            LName = "Samir"
                        });
                });

            modelBuilder.Entity("ITIAcademy.Models.Schedule", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<bool>("FRI")
                        .HasColumnType("bit");

                    b.Property<bool>("MON")
                        .HasColumnType("bit");

                    b.Property<bool>("SAT")
                        .HasColumnType("bit");

                    b.Property<bool>("SUN")
                        .HasColumnType("bit");

                    b.Property<bool>("THU")
                        .HasColumnType("bit");

                    b.Property<bool>("TUE")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("WED")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Schedules", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FRI = false,
                            MON = true,
                            SAT = false,
                            SUN = true,
                            THU = true,
                            TUE = true,
                            Title = "Daily",
                            WED = true
                        },
                        new
                        {
                            Id = 2,
                            FRI = false,
                            MON = false,
                            SAT = false,
                            SUN = true,
                            THU = true,
                            TUE = true,
                            Title = "DayAfterDay",
                            WED = false
                        },
                        new
                        {
                            Id = 3,
                            FRI = false,
                            MON = true,
                            SAT = false,
                            SUN = false,
                            THU = false,
                            TUE = false,
                            Title = "Twice-a-Week",
                            WED = true
                        },
                        new
                        {
                            Id = 4,
                            FRI = true,
                            MON = false,
                            SAT = true,
                            SUN = false,
                            THU = false,
                            TUE = false,
                            Title = "Weekend",
                            WED = false
                        },
                        new
                        {
                            Id = 5,
                            FRI = true,
                            MON = true,
                            SAT = true,
                            SUN = true,
                            THU = true,
                            TUE = true,
                            Title = "Compact",
                            WED = true
                        });
                });

            modelBuilder.Entity("ITIAcademy.Models.Section", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<int?>("CourseId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("InstructorId")
                        .HasColumnType("int");

                    b.Property<int?>("ScheduleId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("SectionName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("VARCHAR");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("InstructorId");

                    b.HasIndex("ScheduleId");

                    b.ToTable("Sections", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CourseId = 1,
                            InstructorId = 1,
                            ScheduleId = 1,
                            SectionName = "S_MA1"
                        },
                        new
                        {
                            Id = 2,
                            CourseId = 1,
                            InstructorId = 2,
                            ScheduleId = 3,
                            SectionName = "S_MA2"
                        },
                        new
                        {
                            Id = 3,
                            CourseId = 5,
                            InstructorId = 1,
                            ScheduleId = 4,
                            SectionName = "S_PH1"
                        },
                        new
                        {
                            Id = 4,
                            CourseId = 9,
                            InstructorId = 4,
                            ScheduleId = 1,
                            SectionName = "S_PH2"
                        },
                        new
                        {
                            Id = 5,
                            CourseId = 7,
                            InstructorId = 6,
                            ScheduleId = 1,
                            SectionName = "S_CH1"
                        },
                        new
                        {
                            Id = 6,
                            CourseId = 5,
                            InstructorId = 7,
                            ScheduleId = 2,
                            SectionName = "S_CH2"
                        },
                        new
                        {
                            Id = 7,
                            CourseId = 2,
                            InstructorId = 9,
                            ScheduleId = 3,
                            SectionName = "S_BI1"
                        },
                        new
                        {
                            Id = 8,
                            CourseId = 6,
                            InstructorId = 5,
                            ScheduleId = 4,
                            SectionName = "S_BI2"
                        },
                        new
                        {
                            Id = 9,
                            CourseId = 10,
                            InstructorId = 8,
                            ScheduleId = 4,
                            SectionName = "S_CS1"
                        },
                        new
                        {
                            Id = 10,
                            CourseId = 4,
                            InstructorId = 10,
                            ScheduleId = 3,
                            SectionName = "S_CS2"
                        },
                        new
                        {
                            Id = 11,
                            CourseId = 2,
                            InstructorId = 9,
                            ScheduleId = 5,
                            SectionName = "S_CS3"
                        });
                });

            modelBuilder.Entity("ITIAcademy.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("FName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("VARCHAR");

                    b.Property<string>("LName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("VARCHAR");

                    b.Property<int>("SectionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SectionId");

                    b.ToTable("Students", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FName = "John",
                            LName = "Doe",
                            SectionId = 1
                        },
                        new
                        {
                            Id = 2,
                            FName = "Jane",
                            LName = "Smith",
                            SectionId = 2
                        },
                        new
                        {
                            Id = 3,
                            FName = "James",
                            LName = "Johnson",
                            SectionId = 3
                        },
                        new
                        {
                            Id = 4,
                            FName = "Emily",
                            LName = "Brown",
                            SectionId = 4
                        },
                        new
                        {
                            Id = 5,
                            FName = "Michal",
                            LName = "Williams",
                            SectionId = 11
                        },
                        new
                        {
                            Id = 6,
                            FName = "Sarah",
                            LName = "Jones",
                            SectionId = 6
                        },
                        new
                        {
                            Id = 7,
                            FName = "Rober",
                            LName = "Garcia",
                            SectionId = 7
                        },
                        new
                        {
                            Id = 8,
                            FName = "David",
                            LName = "Martinez",
                            SectionId = 8
                        },
                        new
                        {
                            Id = 9,
                            FName = "Sophi",
                            LName = "Davis",
                            SectionId = 9
                        },
                        new
                        {
                            Id = 10,
                            FName = "Ahmed",
                            LName = "Salah",
                            SectionId = 10
                        },
                        new
                        {
                            Id = 11,
                            FName = "Sarah",
                            LName = "Jones",
                            SectionId = 6
                        },
                        new
                        {
                            Id = 12,
                            FName = "Jack",
                            LName = "Smith",
                            SectionId = 7
                        },
                        new
                        {
                            Id = 13,
                            FName = "Alfonso",
                            LName = "Davis",
                            SectionId = 8
                        },
                        new
                        {
                            Id = 14,
                            FName = "Reece",
                            LName = "James",
                            SectionId = 11
                        },
                        new
                        {
                            Id = 15,
                            FName = "Karim",
                            LName = "Benzema",
                            SectionId = 11
                        });
                });

            modelBuilder.Entity("ITIAcademy.Models.Section", b =>
                {
                    b.HasOne("ITIAcademy.Models.Course", "Course")
                        .WithMany("Sections")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ITIAcademy.Models.Instructor", "Instructor")
                        .WithMany("Sections")
                        .HasForeignKey("InstructorId");

                    b.HasOne("ITIAcademy.Models.Schedule", "Schedule")
                        .WithMany("Sections")
                        .HasForeignKey("ScheduleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Instructor");

                    b.Navigation("Schedule");
                });

            modelBuilder.Entity("ITIAcademy.Models.Student", b =>
                {
                    b.HasOne("ITIAcademy.Models.Section", "Section")
                        .WithMany("Students")
                        .HasForeignKey("SectionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Section");
                });

            modelBuilder.Entity("ITIAcademy.Models.Course", b =>
                {
                    b.Navigation("Sections");
                });

            modelBuilder.Entity("ITIAcademy.Models.Instructor", b =>
                {
                    b.Navigation("Sections");
                });

            modelBuilder.Entity("ITIAcademy.Models.Schedule", b =>
                {
                    b.Navigation("Sections");
                });

            modelBuilder.Entity("ITIAcademy.Models.Section", b =>
                {
                    b.Navigation("Students");
                });
#pragma warning restore 612, 618
        }
    }
}
