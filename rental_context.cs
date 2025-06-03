using DVD_rental.model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVD_rental
{
    internal class rental_context : DbContext
    {

        public DbSet<Film> Films { get; set; }





        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(AppConfig.GetConnectionString());
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Film>().HasKey(f => f.Id);

            //modelBuilder.Entity<Film>().Property(f => f.Id).UseIdentityColumn();
            //modelBuilder.Entity<Film>().Property(f => f.Title).IsRequired().HasMaxLength(200);
            //modelBuilder.Entity<Film>().Property(f => f.Description).HasMaxLength(200);


            modelBuilder.Entity<Film>(entity =>
            {
              
                entity.Property(f => f.Title).IsRequired().HasMaxLength(200);
                entity.Property(f => f.Description).HasMaxLength(800);
               

            });
        }
    }
}
