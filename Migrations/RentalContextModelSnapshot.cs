﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DVD_rental.Migrations
{
    [DbContext(typeof(RentalContext))]
    partial class RentalContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("DVD_rental.model.Actor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("character varying(45)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("character varying(45)");

                    b.Property<DateTime>("LastUpdate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Actors");
                });

            modelBuilder.Entity("DVD_rental.model.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Address_1")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("Address_2")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("City_Id")
                        .HasColumnType("integer");

                    b.Property<DateTime>("Last_Update")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("Phone")
                        .HasMaxLength(20)
                        .HasColumnType("integer");

                    b.Property<string>("Postal_Code")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("character varying(10)");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)");

                    b.HasKey("Id");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("DVD_rental.model.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("character varying(25)");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("DVD_rental.model.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("City_Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Country_Id")
                        .HasColumnType("integer");

                    b.Property<DateTime>("Last_Update")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("DVD_rental.model.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Country_Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("Last_Update")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("DVD_rental.model.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<bool>("Active")
                        .HasColumnType("boolean");

                    b.Property<string>("Address_Id")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("Create_Date")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("character varying(45)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("character varying(45)");

                    b.Property<DateTime>("LastUpdate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("Store_Id")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("DVD_rental.model.Film", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("Fulltext")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("LanguageId")
                        .HasColumnType("integer");

                    b.Property<int>("Language_Id")
                        .HasColumnType("integer");

                    b.Property<int?>("Length")
                        .HasColumnType("integer");

                    b.Property<string>("Rating")
                        .HasColumnType("text");

                    b.Property<int>("ReleaseYear")
                        .HasColumnType("integer");

                    b.Property<int>("RentalDuration")
                        .HasColumnType("integer");

                    b.Property<decimal>("RentalRate")
                        .HasColumnType("decimal(4,2)");

                    b.Property<decimal>("ReplacementCost")
                        .HasColumnType("decimal(5,2)");

                    b.Property<string>("SpecialFeatures")
                        .HasColumnType("text");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.HasKey("Id");

                    b.HasIndex("LanguageId");

                    b.ToTable("Films");
                });

            modelBuilder.Entity("DVD_rental.model.Inventory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("FilmId")
                        .HasColumnType("integer");

                    b.Property<int>("Film_Id")
                        .HasColumnType("integer");

                    b.Property<DateTime>("Last_Update")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("StoreId")
                        .HasColumnType("integer");

                    b.Property<int>("Store_Id")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("FilmId");

                    b.HasIndex("StoreId");

                    b.ToTable("Inventories");
                });

            modelBuilder.Entity("DVD_rental.model.Language", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Last_update")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)");

                    b.HasKey("Id");

                    b.ToTable("Languages");
                });

            modelBuilder.Entity("DVD_rental.model.Payment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(5,2)");

                    b.Property<int>("Customer_Id")
                        .HasColumnType("integer");

                    b.Property<DateTime>("Payment_Date")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("Rental_Id")
                        .HasColumnType("integer");

                    b.Property<int>("Staff_Id")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("Rental_Id");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("DVD_rental.model.Rental", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CustomerId")
                        .HasColumnType("integer");

                    b.Property<int>("Customer_Id")
                        .HasColumnType("integer");

                    b.Property<int>("InventoryId")
                        .HasColumnType("integer");

                    b.Property<int>("Inventory_Id")
                        .HasColumnType("integer");

                    b.Property<DateTime>("Last_Update")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("Rental_Date")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("Return_Date")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("StaffId")
                        .HasColumnType("integer");

                    b.Property<int>("Staff_Id")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("InventoryId");

                    b.HasIndex("StaffId");

                    b.ToTable("Rentals");
                });

            modelBuilder.Entity("DVD_rental.model.Staff", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<bool>("Active")
                        .HasColumnType("boolean");

                    b.Property<string>("Address_Id")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("character varying(45)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("character varying(45)");

                    b.Property<DateTime>("LastUpdate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("character varying(40)");

                    b.Property<int>("Store_Id")
                        .HasColumnType("integer");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(16)
                        .HasColumnType("character varying(16)");

                    b.HasKey("Id");

                    b.ToTable("Staffs");
                });

            modelBuilder.Entity("DVD_rental.model.Store", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("Address_Id")
                        .HasColumnType("integer");

                    b.Property<DateTime>("LastUpdate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("Manager_Staff_Id")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Stores");
                });

            modelBuilder.Entity("film_actor", b =>
                {
                    b.Property<int>("actor_id")
                        .HasColumnType("integer");

                    b.Property<int>("film_id")
                        .HasColumnType("integer");

                    b.HasKey("actor_id", "film_id");

                    b.HasIndex("film_id");

                    b.ToTable("film_actor");
                });

            modelBuilder.Entity("film_category", b =>
                {
                    b.Property<int>("category_id")
                        .HasColumnType("integer");

                    b.Property<int>("film_id")
                        .HasColumnType("integer");

                    b.HasKey("category_id", "film_id");

                    b.HasIndex("film_id");

                    b.ToTable("film_category");
                });

            modelBuilder.Entity("DVD_rental.model.Film", b =>
                {
                    b.HasOne("DVD_rental.model.Language", "Language")
                        .WithMany()
                        .HasForeignKey("LanguageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Language");
                });

            modelBuilder.Entity("DVD_rental.model.Inventory", b =>
                {
                    b.HasOne("DVD_rental.model.Film", "Film")
                        .WithMany("Inventories")
                        .HasForeignKey("FilmId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DVD_rental.model.Store", "Store")
                        .WithMany()
                        .HasForeignKey("StoreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Film");

                    b.Navigation("Store");
                });

            modelBuilder.Entity("DVD_rental.model.Payment", b =>
                {
                    b.HasOne("DVD_rental.model.Rental", "Rental")
                        .WithMany("Payments")
                        .HasForeignKey("Rental_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Rental");
                });

            modelBuilder.Entity("DVD_rental.model.Rental", b =>
                {
                    b.HasOne("DVD_rental.model.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DVD_rental.model.Inventory", "Inventory")
                        .WithMany("Rentals")
                        .HasForeignKey("InventoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DVD_rental.model.Staff", "Staff")
                        .WithMany()
                        .HasForeignKey("StaffId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Inventory");

                    b.Navigation("Staff");
                });

            modelBuilder.Entity("film_actor", b =>
                {
                    b.HasOne("DVD_rental.model.Actor", null)
                        .WithMany()
                        .HasForeignKey("actor_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DVD_rental.model.Film", null)
                        .WithMany()
                        .HasForeignKey("film_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("film_category", b =>
                {
                    b.HasOne("DVD_rental.model.Category", null)
                        .WithMany()
                        .HasForeignKey("category_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DVD_rental.model.Film", null)
                        .WithMany()
                        .HasForeignKey("film_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DVD_rental.model.Film", b =>
                {
                    b.Navigation("Inventories");
                });

            modelBuilder.Entity("DVD_rental.model.Inventory", b =>
                {
                    b.Navigation("Rentals");
                });

            modelBuilder.Entity("DVD_rental.model.Rental", b =>
                {
                    b.Navigation("Payments");
                });
#pragma warning restore 612, 618
        }
    }
}
