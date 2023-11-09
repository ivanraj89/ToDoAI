﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ToDoAI.Data;

#nullable disable

namespace ToDoAI.Migrations
{
    [DbContext(typeof(ToDoAiAppDbContext))]
    partial class ToDoAiAppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ToDoAI.Models.InputFields", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("ToDo")
                        .HasColumnType("longtext");

                    b.Property<string>("TypeOfHelp")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("InputFields");
                });
#pragma warning restore 612, 618
        }
    }
}
