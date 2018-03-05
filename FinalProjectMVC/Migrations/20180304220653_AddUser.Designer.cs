﻿// <auto-generated />
using FinalProjectMVC.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace FinalProjectMVC.Migrations
{
    [DbContext(typeof(FinalProjectDbContext))]
    [Migration("20180304220653_AddUser")]
    partial class AddUser
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FinalProjectMVC.Models.User", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email");

                    b.Property<string>("Password");

                    b.Property<int>("UserPrefsID");

                    b.Property<string>("Username");

                    b.HasKey("ID");

                    b.HasIndex("UserPrefsID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("FinalProjectMVC.Models.UserPrefs", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("UsersArea");

                    b.Property<string>("UsersCareLevel");

                    b.Property<string>("UsersPrice");

                    b.HasKey("ID");

                    b.ToTable("Preferences");
                });

            modelBuilder.Entity("FinalProjectMVC.Models.User", b =>
                {
                    b.HasOne("FinalProjectMVC.Models.UserPrefs", "Prefs")
                        .WithMany()
                        .HasForeignKey("UserPrefsID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
