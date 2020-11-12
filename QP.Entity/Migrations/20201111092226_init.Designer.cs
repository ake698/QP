﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using QP.Entity;

namespace QP.Entity.Migrations
{
    [DbContext(typeof(QPContext))]
    [Migration("20201111092226_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("QP.Entity.CategoryType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Icon")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<bool>("IsDelete")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint(1)")
                        .HasDefaultValue(false);

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("SeriesTypeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SeriesTypeId");

                    b.ToTable("data_Category");

                    b.HasData(
                        new
                        {
                            Id = 6,
                            IsDelete = false,
                            Name = "动作片",
                            SeriesTypeId = 1
                        });
                });

            modelBuilder.Entity("QP.Entity.Resource", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("IsDelete")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint(1)")
                        .HasDefaultValue(false);

                    b.Property<string>("Link")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("data_Resource");
                });

            modelBuilder.Entity("QP.Entity.SeriesType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("IsDelete")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint(1)")
                        .HasDefaultValue(false);

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("data_Series");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IsDelete = false,
                            Name = "电影"
                        },
                        new
                        {
                            Id = 2,
                            IsDelete = false,
                            Name = "电视剧"
                        },
                        new
                        {
                            Id = 3,
                            IsDelete = false,
                            Name = "综艺"
                        },
                        new
                        {
                            Id = 4,
                            IsDelete = false,
                            Name = "动画"
                        });
                });

            modelBuilder.Entity("QP.Entity.VideoBasicInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Actor")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Alias")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("CategoryTypeId")
                        .HasColumnType("int");

                    b.Property<string>("CategoryTypeNames")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Country")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime>("CreationTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("CreationTime")
                        .HasColumnType("datetime(6)")
                        .HasDefaultValueSql("(now())");

                    b.Property<string>("Describes")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Dierctor")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("En")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Image")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<bool>("IsDelete")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint(1)")
                        .HasDefaultValue(false);

                    b.Property<string>("Language")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime>("LastModificationTime")
                        .HasColumnName("LastModificationTime")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Remark")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("SeriesTypeId")
                        .HasColumnType("int");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryTypeId");

                    b.ToTable("Vod_BasicInfo");
                });

            modelBuilder.Entity("QP.Entity.VideoPlayInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("BasicInfoId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreationTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("CreationTime")
                        .HasColumnType("datetime(6)")
                        .HasDefaultValueSql("(now())");

                    b.Property<bool>("IsDelete")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint(1)")
                        .HasDefaultValue(false);

                    b.Property<string>("Kuyun")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime>("LastModificationTime")
                        .HasColumnName("LastModificationTime")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("M3u8")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Mp4")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("ResourceId")
                        .HasColumnType("int");

                    b.Property<int>("VodId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BasicInfoId");

                    b.HasIndex("ResourceId");

                    b.ToTable("Vod_PlayInfo");
                });

            modelBuilder.Entity("QP.Entity.CategoryType", b =>
                {
                    b.HasOne("QP.Entity.SeriesType", "SeriesType")
                        .WithMany()
                        .HasForeignKey("SeriesTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("QP.Entity.VideoBasicInfo", b =>
                {
                    b.HasOne("QP.Entity.CategoryType", "CategoryType")
                        .WithMany()
                        .HasForeignKey("CategoryTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("QP.Entity.VideoPlayInfo", b =>
                {
                    b.HasOne("QP.Entity.VideoBasicInfo", "VideoBasicInfo")
                        .WithMany()
                        .HasForeignKey("BasicInfoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("QP.Entity.Resource", "Resource")
                        .WithMany()
                        .HasForeignKey("ResourceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
