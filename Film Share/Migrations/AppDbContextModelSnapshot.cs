﻿// <auto-generated />
using System;
using FilmShare.Models.DataAccessLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FilmShare.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FilmShare.Models.Entities.Actor", b =>
                {
                    b.Property<int>("ActorId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ActorName");

                    b.Property<DateTime>("DateOfBirth");

                    b.Property<byte[]>("Photo");

                    b.HasKey("ActorId");

                    b.ToTable("Actors");
                });

            modelBuilder.Entity("FilmShare.Models.Entities.ActorsInFilm", b =>
                {
                    b.Property<int>("ActorId");

                    b.Property<int>("FilmId");

                    b.HasKey("ActorId", "FilmId");

                    b.HasIndex("FilmId");

                    b.ToTable("ActorsInFilms");
                });

            modelBuilder.Entity("FilmShare.Models.Entities.Film", b =>
                {
                    b.Property<int>("FilmId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("AverageRank");

                    b.Property<string>("Country");

                    b.Property<string>("FilmName");

                    b.Property<byte[]>("Poster");

                    b.Property<int>("Year");

                    b.HasKey("FilmId");

                    b.ToTable("Films");
                });

            modelBuilder.Entity("FilmShare.Models.Entities.Permission", b =>
                {
                    b.Property<int>("PermissionId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PermissionName");

                    b.HasKey("PermissionId");

                    b.ToTable("Permissions");
                });

            modelBuilder.Entity("FilmShare.Models.Entities.Profile", b =>
                {
                    b.Property<int>("ProfileId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateOfBirth");

                    b.Property<string>("Name");

                    b.Property<byte[]>("Photo");

                    b.Property<int>("UserId");

                    b.HasKey("ProfileId");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Profiles");
                });

            modelBuilder.Entity("FilmShare.Models.Entities.Rank", b =>
                {
                    b.Property<int>("RankId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("FilmId");

                    b.Property<float>("Rating");

                    b.Property<int>("UserId");

                    b.HasKey("RankId");

                    b.HasIndex("FilmId");

                    b.HasIndex("UserId");

                    b.ToTable("Ranks");
                });

            modelBuilder.Entity("FilmShare.Models.Entities.Relationship", b =>
                {
                    b.Property<int>("RelationshipId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("RelationshipId");

                    b.ToTable("Relationships");
                });

            modelBuilder.Entity("FilmShare.Models.Entities.Review", b =>
                {
                    b.Property<int>("ReviewId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("FilmId");

                    b.Property<float>("Rating");

                    b.Property<DateTime>("ReviewDate");

                    b.Property<string>("Text");

                    b.Property<int>("UserId");

                    b.HasKey("ReviewId");

                    b.HasIndex("FilmId");

                    b.HasIndex("UserId");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("FilmShare.Models.Entities.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email");

                    b.Property<bool>("IsBlocked");

                    b.Property<string>("Login");

                    b.Property<string>("Password");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("FilmShare.Models.Entities.UserPermission", b =>
                {
                    b.Property<int>("PermissionId");

                    b.Property<int>("UserId");

                    b.HasKey("PermissionId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("UserPermissions");
                });

            modelBuilder.Entity("FilmShare.Models.Entities.UserRelationships", b =>
                {
                    b.Property<int>("MainUserId");

                    b.Property<int>("DependentUserId");

                    b.Property<int>("RelationshipId");

                    b.Property<int?>("UserId");

                    b.HasKey("MainUserId", "DependentUserId");

                    b.HasIndex("DependentUserId");

                    b.HasIndex("RelationshipId");

                    b.HasIndex("UserId");

                    b.ToTable("UserRelationships");
                });

            modelBuilder.Entity("FilmShare.Models.Entities.ActorsInFilm", b =>
                {
                    b.HasOne("FilmShare.Models.Entities.Actor", "Actor")
                        .WithMany("ActorsInFilms")
                        .HasForeignKey("ActorId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FilmShare.Models.Entities.Film", "Film")
                        .WithMany("ActorsInFilms")
                        .HasForeignKey("FilmId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FilmShare.Models.Entities.Profile", b =>
                {
                    b.HasOne("FilmShare.Models.Entities.User", "User")
                        .WithOne("Profile")
                        .HasForeignKey("FilmShare.Models.Entities.Profile", "UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FilmShare.Models.Entities.Rank", b =>
                {
                    b.HasOne("FilmShare.Models.Entities.Film", "Film")
                        .WithMany("Ranks")
                        .HasForeignKey("FilmId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FilmShare.Models.Entities.User", "User")
                        .WithMany("Ranks")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FilmShare.Models.Entities.Review", b =>
                {
                    b.HasOne("FilmShare.Models.Entities.Film", "Film")
                        .WithMany("Reviews")
                        .HasForeignKey("FilmId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FilmShare.Models.Entities.User", "User")
                        .WithMany("Reviews")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FilmShare.Models.Entities.UserPermission", b =>
                {
                    b.HasOne("FilmShare.Models.Entities.Permission", "Permission")
                        .WithMany("UserPermissions")
                        .HasForeignKey("PermissionId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FilmShare.Models.Entities.User", "User")
                        .WithMany("UserPermissions")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FilmShare.Models.Entities.UserRelationships", b =>
                {
                    b.HasOne("FilmShare.Models.Entities.User", "DependentUser")
                        .WithMany("DependentUserRelationships")
                        .HasForeignKey("DependentUserId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("FilmShare.Models.Entities.User", "MainUser")
                        .WithMany("MainUserRelationships")
                        .HasForeignKey("MainUserId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("FilmShare.Models.Entities.Relationship", "Relationship")
                        .WithMany()
                        .HasForeignKey("RelationshipId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FilmShare.Models.Entities.User")
                        .WithMany("UserRelationships")
                        .HasForeignKey("UserId");
                });
#pragma warning restore 612, 618
        }
    }
}
