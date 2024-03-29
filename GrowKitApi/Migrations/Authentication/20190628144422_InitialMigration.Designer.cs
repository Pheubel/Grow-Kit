﻿// <auto-generated />
using System;
using GrowKitApi.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace GrowKitApi.Migrations.Authentication
{
    [DbContext(typeof(AuthenticationContext))]
    [Migration("20190628144422_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("GrowKitApi.Entities.AuthenticationUser", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<byte[]>("AuthenticatorSecret");

                    b.Property<short>("Flags");

                    b.Property<string>("NormalizedEmailAdress");

                    b.Property<byte[]>("PasswordHash");

                    b.Property<byte[]>("PasswordSalt");

                    b.Property<long>("PreviousTimeWindow");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("GrowKitApi.Entities.EmailConfirmationRequest", b =>
                {
                    b.Property<long>("UserId");

                    b.Property<Guid>("ConfirmationToken");

                    b.Property<DateTime>("ExpirationDate");

                    b.HasKey("UserId");

                    b.ToTable("EmailConfirmationRequests");
                });

            modelBuilder.Entity("GrowKitApi.Entities.EmailConfirmationRequest", b =>
                {
                    b.HasOne("GrowKitApi.Entities.AuthenticationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
