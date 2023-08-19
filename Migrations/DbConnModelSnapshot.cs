﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using XZRPV.Database;

namespace XZRPV.Migrations
{
    [DbContext(typeof(DbConn))]
    partial class DbConnModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.19")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("XZRPV.Models.House", b =>
                {
                    b.Property<int>("HouseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<float>("EntranceX")
                        .HasColumnType("float");

                    b.Property<float>("EntranceY")
                        .HasColumnType("float");

                    b.Property<float>("EntranceZ")
                        .HasColumnType("float");

                    b.Property<float>("ExitX")
                        .HasColumnType("float");

                    b.Property<float>("ExitY")
                        .HasColumnType("float");

                    b.Property<float>("ExitZ")
                        .HasColumnType("float");

                    b.Property<int>("InteriorId")
                        .HasColumnType("int");

                    b.Property<bool>("IsLocked")
                        .HasColumnType("tinyint(1)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(65,30)");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.Property<uint>("VirtualWorldId")
                        .HasColumnType("int unsigned");

                    b.HasKey("HouseId");

                    b.HasIndex("UserId");

                    b.ToTable("Houses");
                });

            modelBuilder.Entity("XZRPV.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("AdminRankId")
                        .HasColumnType("int");

                    b.Property<decimal>("BankBalance")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("decimal(10, 2)")
                        .HasDefaultValue(0.00m);

                    b.Property<string>("Email")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("FactionId")
                        .HasColumnType("int");

                    b.Property<int>("FactionRankId")
                        .HasColumnType("int");

                    b.Property<string>("Firstname")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<bool>("Gender")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("IsDead")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("JobId")
                        .HasColumnType("int");

                    b.Property<string>("Lastname")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<decimal>("Money")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("decimal(10, 2)")
                        .HasDefaultValue(0.00m);

                    b.Property<string>("Password")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<float>("PosX")
                        .HasColumnType("float");

                    b.Property<float>("PosY")
                        .HasColumnType("float");

                    b.Property<float>("PosZ")
                        .HasColumnType("float");

                    b.Property<string>("Username")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("XZRPV.Models.UserCharacter", b =>
                {
                    b.Property<int>("UserCharacterId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Hair")
                        .HasColumnType("int");

                    b.Property<int>("Legs")
                        .HasColumnType("int");

                    b.Property<int>("Shoes")
                        .HasColumnType("int");

                    b.Property<int>("Top")
                        .HasColumnType("int");

                    b.Property<int>("Torso")
                        .HasColumnType("int");

                    b.Property<int>("Undershirt")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("UserCharacterId");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("UserCharacters");
                });

            modelBuilder.Entity("XZRPV.Models.House", b =>
                {
                    b.HasOne("XZRPV.Models.User", "User")
                        .WithMany("Houses")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("XZRPV.Models.UserCharacter", b =>
                {
                    b.HasOne("XZRPV.Models.User", "User")
                        .WithOne("UserCharacter")
                        .HasForeignKey("XZRPV.Models.UserCharacter", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
