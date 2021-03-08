﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UnicornStore.Data;

namespace UnicornStore.Migrations
{
    [DbContext(typeof(StoreDbContext))]
    [Migration("20210308225038_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("UnicornStore.Models.Power", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Name")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("UnicornId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UnicornId");

                    b.ToTable("Powers");
                });

            modelBuilder.Entity("UnicornStore.Models.Unicorn", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Unicorns");
                });

            modelBuilder.Entity("UnicornStore.Models.Power", b =>
                {
                    b.HasOne("UnicornStore.Models.Unicorn", null)
                        .WithMany("Powers")
                        .HasForeignKey("UnicornId");
                });

            modelBuilder.Entity("UnicornStore.Models.Unicorn", b =>
                {
                    b.Navigation("Powers");
                });
#pragma warning restore 612, 618
        }
    }
}