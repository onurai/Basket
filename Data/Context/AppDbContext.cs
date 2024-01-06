using Basket.Data.Entity;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;

namespace Basket.Data.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Cart> Carts { get; set; }
        public DbSet<BasketItem> BasketItems { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>()
                .ToTable("Orders")
                .HasKey(o => o.Id); 

            modelBuilder.Entity<Cart>()
                .HasOne(c => c.Order)
                .WithOne(o => o.Cart)
                .HasForeignKey<Order>(o => o.Id);
            //
            modelBuilder.Entity<Cart>()
                .HasKey(o => o.Id);

            modelBuilder.Entity<User>()
                .HasOne(u => u.Cart)
                .WithOne(c => c.User)
                .HasForeignKey<Cart>(c => c.Id)
                .OnDelete(DeleteBehavior.Cascade);
            //
            //modelBuilder.Entity<Order>()
            //    .HasOne(o => o.User)
            //    .WithMany(u => u.Orders)
            //    .HasForeignKey(o => o.UserId);

            //modelBuilder.Entity<User>()
            //    .HasMany(o => o.Orders)
            //    .WithOne(u => u.User)    
            //    .HasForeignKey(fk => fk.UserId)
            //    .OnDelete(DeleteBehavior.Cascade);

            base.OnModelCreating(modelBuilder);
        }

    }
}
