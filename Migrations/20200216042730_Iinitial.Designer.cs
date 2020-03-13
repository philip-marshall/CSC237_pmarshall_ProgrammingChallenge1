﻿// <auto-generated />
using System;
using CSC237_pmarshall_ProgrammingChallenge1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CSC237_pmarshall_ProgrammingChallenge1.Migrations
{
    [DbContext(typeof(ContactContext))]
    [Migration("20200216042730_Iinitial")]
    partial class Iinitial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CSC237_pmarshall_ProgrammingChallenge1.Models.Contact", b =>
                {
                    b.Property<int>("ContactId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateAdded")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Organization")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ContactId");

                    b.ToTable("Contacts");

                    b.HasData(
                        new
                        {
                            ContactId = 1,
                            DateAdded = new DateTime(2020, 2, 15, 21, 27, 29, 440, DateTimeKind.Local).AddTicks(3074),
                            Email = "james_marshall48@aol.com",
                            FirstName = "James",
                            LastName = "Marshall",
                            Organization = "Student",
                            Phone = "720-965-1963"
                        },
                        new
                        {
                            ContactId = 2,
                            DateAdded = new DateTime(2020, 2, 15, 21, 27, 29, 444, DateTimeKind.Local).AddTicks(4474),
                            Email = "philip.marshall123456789@gmail.com",
                            FirstName = "Philip",
                            LastName = "Marshall",
                            Organization = "Student",
                            Phone = "720-965-5459"
                        },
                        new
                        {
                            ContactId = 3,
                            DateAdded = new DateTime(2020, 2, 15, 21, 27, 29, 444, DateTimeKind.Local).AddTicks(4535),
                            Email = "keith.howard@whatever.com",
                            FirstName = "Keith",
                            LastName = "Howard",
                            Organization = "Teacher",
                            Phone = "777-777-7777"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}