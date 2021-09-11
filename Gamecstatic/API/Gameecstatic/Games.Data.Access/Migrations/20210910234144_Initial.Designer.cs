﻿// <auto-generated />
using System;
using Games.Data.Access.DataAccessLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Games.Data.Access.Migrations
{
    [DbContext(typeof(MainDbContext))]
    [Migration("20210910234144_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Games.Data.Model.AdditionalGameFile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<byte[]>("Content")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("ContentType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("GameId")
                        .HasColumnType("int");

                    b.Property<string>("GetPath")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("GameId");

                    b.ToTable("AdditionalGameFiles");
                });

            modelBuilder.Entity("Games.Data.Model.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Simulation"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Strategy"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Shooter"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Action"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Adventure"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Platformer"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Puzzle"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Tower Defense"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Idle"
                        },
                        new
                        {
                            Id = 10,
                            Name = "Sandbox"
                        },
                        new
                        {
                            Id = 11,
                            Name = "RPG"
                        },
                        new
                        {
                            Id = 12,
                            Name = "Racing"
                        },
                        new
                        {
                            Id = 13,
                            Name = "Fighter"
                        });
                });

            modelBuilder.Entity("Games.Data.Model.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int?>("GameId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GameId");

                    b.HasIndex("UserId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("Games.Data.Model.Game", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("GameIndexFile")
                        .HasColumnType("varbinary(max)");

                    b.Property<int>("Height")
                        .HasColumnType("int");

                    b.Property<byte[]>("Image")
                        .HasColumnType("varbinary(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PlayCount")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("Width")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Games");
                });

            modelBuilder.Entity("Games.Data.Model.GameCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("GameId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("GameId");

                    b.ToTable("GameCategories");
                });

            modelBuilder.Entity("Games.Data.Model.GameTag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("GameId")
                        .HasColumnType("int");

                    b.Property<int>("TagId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GameId");

                    b.HasIndex("TagId");

                    b.ToTable("GameTags");
                });

            modelBuilder.Entity("Games.Data.Model.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("Games.Data.Model.Tag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tags");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Puzzle"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Music"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Upgrades"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Isometric"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Mouse"
                        },
                        new
                        {
                            Id = 6,
                            Name = "War"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Flight"
                        },
                        new
                        {
                            Id = 8,
                            Name = "5 Minute"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Arcade"
                        },
                        new
                        {
                            Id = 10,
                            Name = "Pixel"
                        },
                        new
                        {
                            Id = 11,
                            Name = "Funny"
                        },
                        new
                        {
                            Id = 12,
                            Name = "Escape"
                        },
                        new
                        {
                            Id = 13,
                            Name = "Fantasy"
                        },
                        new
                        {
                            Id = 14,
                            Name = "Horror"
                        },
                        new
                        {
                            Id = 15,
                            Name = "Card"
                        },
                        new
                        {
                            Id = 16,
                            Name = "Sports"
                        },
                        new
                        {
                            Id = 17,
                            Name = "Space"
                        },
                        new
                        {
                            Id = 18,
                            Name = "Zombie"
                        },
                        new
                        {
                            Id = 19,
                            Name = "Alien"
                        },
                        new
                        {
                            Id = 20,
                            Name = "Science Fiction"
                        },
                        new
                        {
                            Id = 21,
                            Name = "Relaxing"
                        },
                        new
                        {
                            Id = 22,
                            Name = "Turn Based"
                        },
                        new
                        {
                            Id = 23,
                            Name = "Maze"
                        },
                        new
                        {
                            Id = 24,
                            Name = "Dungeon"
                        },
                        new
                        {
                            Id = 25,
                            Name = "Quiz"
                        },
                        new
                        {
                            Id = 26,
                            Name = "Challenging"
                        },
                        new
                        {
                            Id = 27,
                            Name = "Survival"
                        },
                        new
                        {
                            Id = 28,
                            Name = "Dating"
                        },
                        new
                        {
                            Id = 29,
                            Name = "Text Based"
                        });
                });

            modelBuilder.Entity("Games.Data.Model.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Games.Data.Model.UserGameRating", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("GameId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GameId");

                    b.HasIndex("UserId");

                    b.ToTable("UserGameRatings");
                });

            modelBuilder.Entity("Games.Data.Model.UserRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId");

                    b.ToTable("UserRoles");
                });

            modelBuilder.Entity("Games.Data.Model.AdditionalGameFile", b =>
                {
                    b.HasOne("Games.Data.Model.Game", null)
                        .WithMany("AdditionalGameFiles")
                        .HasForeignKey("GameId");
                });

            modelBuilder.Entity("Games.Data.Model.Comment", b =>
                {
                    b.HasOne("Games.Data.Model.Game", null)
                        .WithMany("Comments")
                        .HasForeignKey("GameId");

                    b.HasOne("Games.Data.Model.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Games.Data.Model.Game", b =>
                {
                    b.HasOne("Games.Data.Model.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Games.Data.Model.GameCategory", b =>
                {
                    b.HasOne("Games.Data.Model.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Games.Data.Model.Game", "Game")
                        .WithMany("Categories")
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Game");
                });

            modelBuilder.Entity("Games.Data.Model.GameTag", b =>
                {
                    b.HasOne("Games.Data.Model.Game", "Game")
                        .WithMany("Tags")
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Games.Data.Model.Tag", "Tag")
                        .WithMany()
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Game");

                    b.Navigation("Tag");
                });

            modelBuilder.Entity("Games.Data.Model.UserGameRating", b =>
                {
                    b.HasOne("Games.Data.Model.Game", "Game")
                        .WithMany("UserRatings")
                        .HasForeignKey("GameId");

                    b.HasOne("Games.Data.Model.User", "User")
                        .WithMany("GameRatings")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Game");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Games.Data.Model.UserRole", b =>
                {
                    b.HasOne("Games.Data.Model.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Games.Data.Model.User", "User")
                        .WithMany("Roles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Games.Data.Model.Game", b =>
                {
                    b.Navigation("AdditionalGameFiles");

                    b.Navigation("Categories");

                    b.Navigation("Comments");

                    b.Navigation("Tags");

                    b.Navigation("UserRatings");
                });

            modelBuilder.Entity("Games.Data.Model.User", b =>
                {
                    b.Navigation("GameRatings");

                    b.Navigation("Roles");
                });
#pragma warning restore 612, 618
        }
    }
}
