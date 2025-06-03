using DVD_rental;
using DVD_rental.model;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

public class RentalContext : DbContext
{
 
    public DbSet<Film> Films { get; set; }
    public DbSet<Actor> Actors { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Language> Languages { get; set; }
    public DbSet<Inventory> Inventories { get; set; }
    public DbSet<Rental> Rentals { get; set; }
    public DbSet<Payment> Payments { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Staff> Staffs { get; set; }
    public DbSet<Store> Stores { get; set; }
    public DbSet<Address> Addresses { get; set; }
    public DbSet<City> Cities { get; set; }
    public DbSet<Country> Countries { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseNpgsql(AppConfig.GetConnectionString());
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // === Configurazioni NOT NULL (Fluent API) ===

        // Film
        modelBuilder.Entity<Film>(entity =>
        {
            entity.Property(f => f.Title).IsRequired().HasMaxLength(200);
            entity.Property(f => f.ReleaseYear).IsRequired();
            entity.Property(f => f.Language_Id).IsRequired();
            entity.Property(f => f.RentalDuration).IsRequired();
            entity.Property(f => f.RentalRate).IsRequired().HasColumnType("decimal(4,2)");
            entity.Property(f => f.ReplacementCost).IsRequired().HasColumnType("decimal(5,2)");
        });

        // Actor
        modelBuilder.Entity<Actor>(entity =>
        {
            entity.Property(a => a.FirstName).IsRequired().HasMaxLength(45);
            entity.Property(a => a.LastName).IsRequired().HasMaxLength(45);
        });

        // Category
        modelBuilder.Entity<Category>(entity =>
        {
            entity.Property(c => c.Name).IsRequired().HasMaxLength(25);
        });

        // Language
        modelBuilder.Entity<Language>(entity =>
        {
            entity.Property(l => l.Name).IsRequired().HasMaxLength(20);
        });

        // Inventory
        modelBuilder.Entity<Inventory>(entity =>
        {
            entity.Property(i => i.Film_Id).IsRequired();
            entity.Property(i => i.Store_Id).IsRequired();
        });

        // Rental
        modelBuilder.Entity<Rental>(entity =>
        {
            entity.Property(r => r.Rental_Date).IsRequired();
            entity.Property(r => r.Inventory_Id).IsRequired();
            entity.Property(r => r.Customer_Id).IsRequired();
            entity.Property(r => r.Staff_Id).IsRequired();
        });

        // Payment
        modelBuilder.Entity<Payment>(entity =>
        {
            entity.Property(p => p.Customer_Id).IsRequired();
            entity.Property(p => p.Staff_Id).IsRequired();
            entity.Property(p => p.Amount).IsRequired().HasColumnType("decimal(5,2)");
            entity.Property(p => p.Payment_Date).IsRequired();
        });

        // Customer
        modelBuilder.Entity<Customer>(entity =>
        {
            entity.Property(c => c.Store_Id).IsRequired();
            entity.Property(c => c.FirstName).IsRequired().HasMaxLength(45);
            entity.Property(c => c.LastName).IsRequired().HasMaxLength(45);
            entity.Property(c => c.Address_Id).IsRequired();
            entity.Property(c => c.Active).IsRequired();
            entity.Property(c => c.Create_Date).IsRequired();
        });

        // Staff
        modelBuilder.Entity<Staff>(entity =>
        {
            entity.Property(s => s.FirstName).IsRequired().HasMaxLength(45);
            entity.Property(s => s.LastName).IsRequired().HasMaxLength(45);
            entity.Property(s => s.Address_Id).IsRequired();
            entity.Property(s => s.Store_Id).IsRequired();
            entity.Property(s => s.Active).IsRequired();
            entity.Property(s => s.Username).IsRequired().HasMaxLength(16);
            entity.Property(s => s.Password).IsRequired().HasMaxLength(40);
        });

        // Store
        modelBuilder.Entity<Store>(entity =>
        {
            entity.Property(s => s.Manager_Staff_Id).IsRequired();
            entity.Property(s => s.Address_Id).IsRequired();
        });

        // Address, City, Country (esempio)
        modelBuilder.Entity<Address>(entity =>
        {
            entity.Property(a => a.Address_1).IsRequired().HasMaxLength(50);
            entity.Property(a => a.State).IsRequired().HasMaxLength(20);
            entity.Property(a => a.City_Id).IsRequired();
            entity.Property(a => a.Postal_Code).HasMaxLength(10);
            entity.Property(a => a.Phone).IsRequired().HasMaxLength(20);
        });

        // === Relazioni molti-a-molti ===
        modelBuilder.Entity<Film>()
            .HasMany(f => f.Actors)
            .WithMany(a => a.Films)
            .UsingEntity<Dictionary<string, object>>(
                "film_actor",
                j => j.HasOne<Actor>().WithMany().HasForeignKey("actor_id"),
                j => j.HasOne<Film>().WithMany().HasForeignKey("film_id")
            );

        modelBuilder.Entity<Film>()
            .HasMany(f => f.Categories)
            .WithMany(c => c.Films)
            .UsingEntity<Dictionary<string, object>>(
                "film_category",
                j => j.HasOne<Category>().WithMany().HasForeignKey("category_id"),
                j => j.HasOne<Film>().WithMany().HasForeignKey("film_id")
            );

        // === Chiavi esterne aggiuntive ===
        // Esempio: Payment -> Rental (nullable)
        modelBuilder.Entity<Payment>()
            .HasOne(p => p.Rental)
            .WithMany(r => r.Payments)
            .HasForeignKey(p => p.Rental_Id);
           
    }
}