using ConcertTicketing.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace ConcertTicketing.Data
{
    public class ConcertTicketContext : DbContext
    {
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Concert> Concerts { get; set; }
        public DbSet<Ticket> Tickets { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // ⚙️ Ganti koneksi sesuai database PostgreSQL kamu
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=db_vb2_concert_ticketing;Username=postgres;Password=test");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // ✅ Relasi: Account -> Tickets (1 ke banyak)
            modelBuilder.Entity<Account>()
                .HasMany(a => a.Tickets)
                .WithOne(t => t.Account)
                .HasForeignKey(t => t.AccountId);

            // ✅ Relasi: Concert -> Tickets (1 ke banyak)
            modelBuilder.Entity<Concert>()
                .HasMany(c => c.Tickets)
                .WithOne(t => t.Concert)
                .HasForeignKey(t => t.ConcertId);

            // ✅ Index unik untuk TicketNumber
            modelBuilder.Entity<Ticket>()
                .HasIndex(t => t.TicketNumber)
                .IsUnique();

            base.OnModelCreating(modelBuilder);
        }
    }
}
