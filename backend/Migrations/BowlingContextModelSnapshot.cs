﻿// <auto-generated />
using BowlingAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BowlingAPI.Migrations
{
    [DbContext(typeof(BowlingContext))]
    partial class BowlingContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.3");

            modelBuilder.Entity("BowlingAPI.Models.Bowler", b =>
                {
                    b.Property<int>("BowlerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("BowlerAddress")
                        .HasColumnType("TEXT");

                    b.Property<string>("BowlerCity")
                        .HasColumnType("TEXT");

                    b.Property<string>("BowlerFirstName")
                        .HasColumnType("TEXT");

                    b.Property<string>("BowlerLastName")
                        .HasColumnType("TEXT");

                    b.Property<string>("BowlerMiddleInit")
                        .HasColumnType("TEXT");

                    b.Property<string>("BowlerPhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<string>("BowlerState")
                        .HasColumnType("TEXT");

                    b.Property<string>("BowlerZip")
                        .HasColumnType("TEXT");

                    b.Property<int?>("TeamID")
                        .HasColumnType("INTEGER");

                    b.HasKey("BowlerID");

                    b.HasIndex("TeamID");

                    b.ToTable("Bowler", (string)null);
                });

            modelBuilder.Entity("BowlingAPI.Models.Team", b =>
                {
                    b.Property<int>("TeamID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("TeamName")
                        .HasColumnType("TEXT");

                    b.HasKey("TeamID");

                    b.ToTable("Team", (string)null);
                });

            modelBuilder.Entity("BowlingAPI.Models.Bowler", b =>
                {
                    b.HasOne("BowlingAPI.Models.Team", "Team")
                        .WithMany()
                        .HasForeignKey("TeamID");

                    b.Navigation("Team");
                });
#pragma warning restore 612, 618
        }
    }
}
