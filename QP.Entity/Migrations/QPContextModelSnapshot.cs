﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using QP.Entity;

namespace QP.Entity.Migrations
{
    [DbContext(typeof(QPContext))]
    partial class QPContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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
                        },
                        new
                        {
                            Id = 7,
                            IsDelete = false,
                            Name = "喜剧",
                            SeriesTypeId = 1
                        },
                        new
                        {
                            Id = 8,
                            IsDelete = false,
                            Name = "爱情片",
                            SeriesTypeId = 1
                        },
                        new
                        {
                            Id = 9,
                            IsDelete = false,
                            Name = "科幻片",
                            SeriesTypeId = 1
                        },
                        new
                        {
                            Id = 10,
                            IsDelete = false,
                            Name = "恐怖片",
                            SeriesTypeId = 1
                        },
                        new
                        {
                            Id = 11,
                            IsDelete = false,
                            Name = "剧情片",
                            SeriesTypeId = 1
                        },
                        new
                        {
                            Id = 12,
                            IsDelete = false,
                            Name = "战争片",
                            SeriesTypeId = 1
                        },
                        new
                        {
                            Id = 13,
                            IsDelete = false,
                            Name = "国产剧",
                            SeriesTypeId = 2
                        },
                        new
                        {
                            Id = 14,
                            IsDelete = false,
                            Name = "港剧",
                            SeriesTypeId = 2
                        },
                        new
                        {
                            Id = 15,
                            IsDelete = false,
                            Name = "韩剧",
                            SeriesTypeId = 2
                        },
                        new
                        {
                            Id = 16,
                            IsDelete = false,
                            Name = "欧美剧",
                            SeriesTypeId = 2
                        },
                        new
                        {
                            Id = 20,
                            IsDelete = false,
                            Name = "纪录片",
                            SeriesTypeId = 2
                        },
                        new
                        {
                            Id = 21,
                            IsDelete = false,
                            Name = "微电影",
                            SeriesTypeId = 2
                        },
                        new
                        {
                            Id = 22,
                            IsDelete = false,
                            Name = "台湾剧",
                            SeriesTypeId = 2
                        },
                        new
                        {
                            Id = 23,
                            IsDelete = false,
                            Name = "日剧",
                            SeriesTypeId = 2
                        },
                        new
                        {
                            Id = 25,
                            IsDelete = false,
                            Name = "大陆综艺",
                            SeriesTypeId = 3
                        },
                        new
                        {
                            Id = 26,
                            IsDelete = false,
                            Name = "港台综艺",
                            SeriesTypeId = 3
                        },
                        new
                        {
                            Id = 27,
                            IsDelete = false,
                            Name = "日韩综艺",
                            SeriesTypeId = 3
                        },
                        new
                        {
                            Id = 28,
                            IsDelete = false,
                            Name = "欧美综艺",
                            SeriesTypeId = 3
                        },
                        new
                        {
                            Id = 29,
                            IsDelete = false,
                            Name = "国产动漫",
                            SeriesTypeId = 4
                        },
                        new
                        {
                            Id = 30,
                            IsDelete = false,
                            Name = "日韩动漫",
                            SeriesTypeId = 4
                        },
                        new
                        {
                            Id = 31,
                            IsDelete = false,
                            Name = "欧美动漫",
                            SeriesTypeId = 4
                        },
                        new
                        {
                            Id = 32,
                            IsDelete = false,
                            Name = "港台动漫",
                            SeriesTypeId = 4
                        },
                        new
                        {
                            Id = 33,
                            IsDelete = false,
                            Name = "其他",
                            SeriesTypeId = 4
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

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IsDelete = false,
                            Link = "http://api.iokzy.com/",
                            Name = "OK"
                        });
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
                        .HasColumnName("CreationTime")
                        .HasColumnType("datetime")
                        .HasMaxLength(0);

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
                        .HasColumnType("datetime")
                        .HasMaxLength(0);

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
                        .HasColumnName("CreationTime")
                        .HasColumnType("datetime")
                        .HasMaxLength(0);

                    b.Property<bool>("IsDelete")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint(1)")
                        .HasDefaultValue(false);

                    b.Property<string>("Kuyun")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime>("LastModificationTime")
                        .HasColumnName("LastModificationTime")
                        .HasColumnType("datetime")
                        .HasMaxLength(0);

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
