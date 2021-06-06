﻿// <auto-generated />
using System;
using DataLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataLayer.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20210316185718_qwe")]
    partial class qwe
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ArtistConcert", b =>
                {
                    b.Property<int>("ArtistsId")
                        .HasColumnType("int");

                    b.Property<int>("ConcertsId")
                        .HasColumnType("int");

                    b.HasKey("ArtistsId", "ConcertsId");

                    b.HasIndex("ConcertsId");

                    b.ToTable("ArtistConcert");
                });

            modelBuilder.Entity("ArtistGenre", b =>
                {
                    b.Property<int>("ArtistsId")
                        .HasColumnType("int");

                    b.Property<string>("GenresName")
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("ArtistsId", "GenresName");

                    b.HasIndex("GenresName");

                    b.ToTable("ArtistGenre");
                });

            modelBuilder.Entity("DataLayer.Entities.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ConcertId")
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("PersonId")
                        .HasColumnType("int");

                    b.Property<DateTime>("PublishTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ConcertId");

                    b.HasIndex("PersonId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("DataLayer.Entities.Concert", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ConcertHallId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ConcertHallId");

                    b.ToTable("Concerts");
                });

            modelBuilder.Entity("DataLayer.Entities.ConcertHall", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ConcertHalls");
                });

            modelBuilder.Entity("DataLayer.Entities.Genre", b =>
                {
                    b.Property<string>("Name")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Name");

                    b.ToTable("Genres");
                });

            modelBuilder.Entity("DataLayer.Entities.Like", b =>
                {
                    b.Property<int>("PersonId")
                        .HasColumnType("int");

                    b.Property<int>("CommentId")
                        .HasColumnType("int");

                    b.HasKey("PersonId", "CommentId");

                    b.HasIndex("CommentId");

                    b.ToTable("Like");
                });

            modelBuilder.Entity("DataLayer.Entities.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MailAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Pass")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.ToTable("Person");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Person");
                });

            modelBuilder.Entity("DataLayer.Entities.Admin", b =>
                {
                    b.HasBaseType("DataLayer.Entities.Person");

                    b.HasDiscriminator().HasValue("Admin");
                });

            modelBuilder.Entity("DataLayer.Entities.Artist", b =>
                {
                    b.HasBaseType("DataLayer.Entities.Person");

                    b.HasDiscriminator().HasValue("Artist");
                });

            modelBuilder.Entity("DataLayer.Entities.Viewer", b =>
                {
                    b.HasBaseType("DataLayer.Entities.Person");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("Viewer");
                });

            modelBuilder.Entity("ArtistConcert", b =>
                {
                    b.HasOne("DataLayer.Entities.Artist", null)
                        .WithMany()
                        .HasForeignKey("ArtistsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataLayer.Entities.Concert", null)
                        .WithMany()
                        .HasForeignKey("ConcertsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ArtistGenre", b =>
                {
                    b.HasOne("DataLayer.Entities.Artist", null)
                        .WithMany()
                        .HasForeignKey("ArtistsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataLayer.Entities.Genre", null)
                        .WithMany()
                        .HasForeignKey("GenresName")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DataLayer.Entities.Comment", b =>
                {
                    b.HasOne("DataLayer.Entities.Concert", null)
                        .WithMany("Comments")
                        .HasForeignKey("ConcertId");

                    b.HasOne("DataLayer.Entities.Person", "Person")
                        .WithMany("Comments")
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Person");
                });

            modelBuilder.Entity("DataLayer.Entities.Concert", b =>
                {
                    b.HasOne("DataLayer.Entities.ConcertHall", "ConcertHall")
                        .WithMany("Concerts")
                        .HasForeignKey("ConcertHallId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ConcertHall");
                });

            modelBuilder.Entity("DataLayer.Entities.Like", b =>
                {
                    b.HasOne("DataLayer.Entities.Comment", "Comment")
                        .WithMany("Likes")
                        .HasForeignKey("CommentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataLayer.Entities.Person", "Person")
                        .WithMany("Likes")
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Comment");

                    b.Navigation("Person");
                });

            modelBuilder.Entity("DataLayer.Entities.Comment", b =>
                {
                    b.Navigation("Likes");
                });

            modelBuilder.Entity("DataLayer.Entities.Concert", b =>
                {
                    b.Navigation("Comments");
                });

            modelBuilder.Entity("DataLayer.Entities.ConcertHall", b =>
                {
                    b.Navigation("Concerts");
                });

            modelBuilder.Entity("DataLayer.Entities.Person", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("Likes");
                });
#pragma warning restore 612, 618
        }
    }
}