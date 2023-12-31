﻿// <auto-generated />
using System;
using Light.Design.Pro.CSharp.EntityFramework.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Light.Design.Pro.CSharp.Database.Migrations.Migrations
{
    [DbContext(typeof(DefaultDbContext))]
    [Migration("20230925031853_v1.0.0")]
    partial class v100
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Light.Design.Pro.CSharp.Application.Users.UserDto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Account")
                        .HasColumnType("longtext");

                    b.Property<DateTimeOffset>("CreatedTime")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .HasColumnType("longtext");

                    b.Property<string>("NickName")
                        .HasColumnType("longtext");

                    b.Property<string>("Password")
                        .HasColumnType("longtext");

                    b.Property<DateTimeOffset?>("UpdatedTime")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.ToTable("UserDto");

                    b.HasDiscriminator<string>("Discriminator").HasValue("UserDto");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("Light.Design.Pro.CSharp.Application.Models.User", b =>
                {
                    b.HasBaseType("Light.Design.Pro.CSharp.Application.Users.UserDto");

                    b.Property<bool?>("EmailConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.HasDiscriminator().HasValue("User");
                });
#pragma warning restore 612, 618
        }
    }
}
