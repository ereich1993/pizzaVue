﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PizzaVueBackend.Data;

namespace PizzaVueBackend.Migrations
{
    [DbContext(typeof(PizzaBackendDbContext))]
    partial class PizzaBackendDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PizzaVueBackend.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Image");

                    b.Property<string>("Name");

                    b.Property<int>("Price");

                    b.Property<int?>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("PizzaVueBackend.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email");

                    b.Property<string>("Password");

                    b.Property<string>("UserName");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("PizzaVueBackend.Models.Product", b =>
                {
                    b.HasOne("PizzaVueBackend.Models.User")
                        .WithMany("Products")
                        .HasForeignKey("UserId");
                });
#pragma warning restore 612, 618
        }
    }
}
