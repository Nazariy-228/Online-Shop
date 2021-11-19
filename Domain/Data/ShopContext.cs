using Domain.DataConfiguration;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Domain.Data
{
    public sealed class ShopContext : DbContext
    {
        public ShopContext(DbContextOptions<ShopContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
        
        public DbSet<Incidents>? Incidents { get; set; }
        
        public DbSet<Accounts>? Accounts { get; set; }

        public DbSet<Contacts>? Contacts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AccountsConfiguration());
            modelBuilder.ApplyConfiguration(new ContactsConfiguration());
            modelBuilder.ApplyConfiguration(new IncidentsConfiguration());
        }
    }
}