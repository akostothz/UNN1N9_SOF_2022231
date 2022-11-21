﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using UNN1N9_SOF_2022231_BACKEND.Data;

#nullable disable

namespace UNN1N9SOF2022231BACKEND.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20221120214420_genderAdded")]
    partial class genderAdded
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseSerialColumns(modelBuilder);

            modelBuilder.Entity("UNN1N9_SOF_2022231_BACKEND.Models.AppUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<int>("Id"));

                    b.Property<int>("Age")
                        .HasColumnType("integer");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("UNN1N9_SOF_2022231_BACKEND.Models.Music", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<int>("Id"));

                    b.Property<double>("Acousticness")
                        .HasColumnType("double precision");

                    b.Property<string>("ArtistName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<double>("Danceability")
                        .HasColumnType("double precision");

                    b.Property<int>("DurationMs")
                        .HasColumnType("integer");

                    b.Property<double>("Energy")
                        .HasColumnType("double precision");

                    b.Property<string>("Genre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("Key")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("character varying(2)");

                    b.Property<double>("Liveness")
                        .HasColumnType("double precision");

                    b.Property<double>("Loudness")
                        .HasColumnType("double precision");

                    b.Property<string>("Mode")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("character varying(5)");

                    b.Property<int>("Popularity")
                        .HasColumnType("integer");

                    b.Property<double>("Speechiness")
                        .HasColumnType("double precision");

                    b.Property<double>("Tempo")
                        .HasColumnType("double precision");

                    b.Property<string>("TrackId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("TrackName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<double>("Valence")
                        .HasColumnType("double precision");

                    b.HasKey("Id");

                    b.ToTable("Musics");
                });

            modelBuilder.Entity("UNN1N9_SOF_2022231_BACKEND.Models.UserBehavior", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseSerialColumn(b.Property<int>("Id"));

                    b.Property<int>("ListeningCount")
                        .HasColumnType("integer");

                    b.Property<int>("MusicId")
                        .HasColumnType("integer");

                    b.Property<string>("NameOfDay")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("character varying(10)");

                    b.Property<string>("TimeOfDay")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("MusicId");

                    b.HasIndex("UserId");

                    b.ToTable("UserBehaviors");
                });

            modelBuilder.Entity("UNN1N9_SOF_2022231_BACKEND.Models.UserBehavior", b =>
                {
                    b.HasOne("UNN1N9_SOF_2022231_BACKEND.Models.Music", "Music")
                        .WithMany("UserBehaviors")
                        .HasForeignKey("MusicId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UNN1N9_SOF_2022231_BACKEND.Models.AppUser", "User")
                        .WithMany("Behaviors")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Music");

                    b.Navigation("User");
                });

            modelBuilder.Entity("UNN1N9_SOF_2022231_BACKEND.Models.AppUser", b =>
                {
                    b.Navigation("Behaviors");
                });

            modelBuilder.Entity("UNN1N9_SOF_2022231_BACKEND.Models.Music", b =>
                {
                    b.Navigation("UserBehaviors");
                });
#pragma warning restore 612, 618
        }
    }
}