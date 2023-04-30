﻿// <auto-generated />
using Final_Project.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Final_Project.Migrations
{
    [DbContext(typeof(LaborShare))]
    [Migration("20230423224640_newTrial")]
    partial class newTrial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Final_Project.Models.Documentation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("DoerId")
                        .HasColumnType("integer");

                    b.Property<string>("Image")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("DoerId");

                    b.ToTable("Documentations");
                });

            modelBuilder.Entity("Final_Project.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("OrderId"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PosterName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ServiceType")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("TaskId")
                        .HasColumnType("integer");

                    b.Property<int>("TaskPosterId")
                        .HasColumnType("integer");

                    b.Property<string>("mail")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("OrderId");

                    b.HasIndex("TaskId");

                    b.HasIndex("TaskPosterId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Final_Project.Models.Payment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<double>("PaymentAmount")
                        .HasColumnType("double precision");

                    b.Property<int>("TaskDoerID")
                        .HasColumnType("integer");

                    b.Property<int>("TaskPosterID")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("TaskDoerID");

                    b.HasIndex("TaskPosterID");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("Final_Project.Models.Skill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Skills");
                });

            modelBuilder.Entity("Final_Project.Models.Task", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<double>("MinimumAmount")
                        .HasColumnType("double precision");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Tasks");
                });

            modelBuilder.Entity("Final_Project.Models.TaskDoer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<float>("SalaryPerHour")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.ToTable("TaskDoers");
                });

            modelBuilder.Entity("Final_Project.Models.TaskPoster", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Phone")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("TaskPosters");
                });

            modelBuilder.Entity("SkillTaskDoer", b =>
                {
                    b.Property<int>("SkillsId")
                        .HasColumnType("integer");

                    b.Property<int>("taskDoersId")
                        .HasColumnType("integer");

                    b.HasKey("SkillsId", "taskDoersId");

                    b.HasIndex("taskDoersId");

                    b.ToTable("SkillTaskDoer");
                });

            modelBuilder.Entity("TaskTaskDoer", b =>
                {
                    b.Property<int>("TaskdoersId")
                        .HasColumnType("integer");

                    b.Property<int>("TasksId")
                        .HasColumnType("integer");

                    b.HasKey("TaskdoersId", "TasksId");

                    b.HasIndex("TasksId");

                    b.ToTable("TaskTaskDoer");
                });

            modelBuilder.Entity("TaskTaskPoster", b =>
                {
                    b.Property<int>("taskPostersId")
                        .HasColumnType("integer");

                    b.Property<int>("tasksId")
                        .HasColumnType("integer");

                    b.HasKey("taskPostersId", "tasksId");

                    b.HasIndex("tasksId");

                    b.ToTable("TaskTaskPoster");
                });

            modelBuilder.Entity("Final_Project.Models.Documentation", b =>
                {
                    b.HasOne("Final_Project.Models.TaskDoer", "Doer")
                        .WithMany("documentations")
                        .HasForeignKey("DoerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Doer");
                });

            modelBuilder.Entity("Final_Project.Models.Order", b =>
                {
                    b.HasOne("Final_Project.Models.Task", "Task")
                        .WithMany()
                        .HasForeignKey("TaskId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Final_Project.Models.TaskPoster", "TaskPoster")
                        .WithMany()
                        .HasForeignKey("TaskPosterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Task");

                    b.Navigation("TaskPoster");
                });

            modelBuilder.Entity("Final_Project.Models.Payment", b =>
                {
                    b.HasOne("Final_Project.Models.TaskDoer", "TaskDoer")
                        .WithMany("payments")
                        .HasForeignKey("TaskDoerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Final_Project.Models.TaskPoster", "TaskPoster")
                        .WithMany("Payments")
                        .HasForeignKey("TaskPosterID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TaskDoer");

                    b.Navigation("TaskPoster");
                });

            modelBuilder.Entity("SkillTaskDoer", b =>
                {
                    b.HasOne("Final_Project.Models.Skill", null)
                        .WithMany()
                        .HasForeignKey("SkillsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Final_Project.Models.TaskDoer", null)
                        .WithMany()
                        .HasForeignKey("taskDoersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TaskTaskDoer", b =>
                {
                    b.HasOne("Final_Project.Models.TaskDoer", null)
                        .WithMany()
                        .HasForeignKey("TaskdoersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Final_Project.Models.Task", null)
                        .WithMany()
                        .HasForeignKey("TasksId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TaskTaskPoster", b =>
                {
                    b.HasOne("Final_Project.Models.TaskPoster", null)
                        .WithMany()
                        .HasForeignKey("taskPostersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Final_Project.Models.Task", null)
                        .WithMany()
                        .HasForeignKey("tasksId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Final_Project.Models.TaskDoer", b =>
                {
                    b.Navigation("documentations");

                    b.Navigation("payments");
                });

            modelBuilder.Entity("Final_Project.Models.TaskPoster", b =>
                {
                    b.Navigation("Payments");
                });
#pragma warning restore 612, 618
        }
    }
}
