﻿// <auto-generated />
using System;
using Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Database.Migrations
{
    [DbContext(typeof(ApplicationDataContext))]
    [Migration("20230605030134_initial")]
    partial class initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Database.Tables.DayDB", b =>
                {
                    b.Property<int>("DayId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DayId"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.HasKey("DayId");

                    b.ToTable("Days");
                });

            modelBuilder.Entity("Database.Tables.IntervalDB", b =>
                {
                    b.Property<int>("IntervalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IntervalId"));

                    b.Property<int>("FirstTimeHour")
                        .HasColumnType("int");

                    b.Property<int>("FirstTimeMinute")
                        .HasColumnType("int");

                    b.Property<int>("LastTimeHour")
                        .HasColumnType("int");

                    b.Property<int>("LastTimeMinute")
                        .HasColumnType("int");

                    b.HasKey("IntervalId");

                    b.ToTable("Intervals");
                });

            modelBuilder.Entity("Database.Tables.LessonDB", b =>
                {
                    b.Property<int>("LessonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LessonId"));

                    b.Property<int>("DayId")
                        .HasColumnType("int");

                    b.Property<int>("IntervalId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Progress")
                        .HasColumnType("bit");

                    b.Property<int>("RoomId")
                        .HasColumnType("int");

                    b.Property<string>("Task")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TeacherId")
                        .HasColumnType("int");

                    b.HasKey("LessonId");

                    b.HasIndex("DayId");

                    b.HasIndex("IntervalId");

                    b.HasIndex("RoomId");

                    b.HasIndex("TeacherId");

                    b.ToTable("Lessons");
                });

            modelBuilder.Entity("Database.Tables.RoomDB", b =>
                {
                    b.Property<int>("RoomId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RoomId"));

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.HasKey("RoomId");

                    b.ToTable("Rooms");
                });

            modelBuilder.Entity("Database.Tables.TeacherDB", b =>
                {
                    b.Property<int>("TeacherId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TeacherId"));

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecondName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TeacherId");

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("Database.Tables.LessonDB", b =>
                {
                    b.HasOne("Database.Tables.DayDB", "Day")
                        .WithMany("Lesson")
                        .HasForeignKey("DayId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Database.Tables.IntervalDB", "Interval")
                        .WithMany("Lesson")
                        .HasForeignKey("IntervalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Database.Tables.RoomDB", "Room")
                        .WithMany("Lesson")
                        .HasForeignKey("RoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Database.Tables.TeacherDB", "Teacher")
                        .WithMany("Lesson")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Day");

                    b.Navigation("Interval");

                    b.Navigation("Room");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("Database.Tables.DayDB", b =>
                {
                    b.Navigation("Lesson");
                });

            modelBuilder.Entity("Database.Tables.IntervalDB", b =>
                {
                    b.Navigation("Lesson");
                });

            modelBuilder.Entity("Database.Tables.RoomDB", b =>
                {
                    b.Navigation("Lesson");
                });

            modelBuilder.Entity("Database.Tables.TeacherDB", b =>
                {
                    b.Navigation("Lesson");
                });
#pragma warning restore 612, 618
        }
    }
}
