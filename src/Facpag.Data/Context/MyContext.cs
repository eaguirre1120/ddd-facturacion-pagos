using Facpag.Data.Mapping;
using Facpag.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Facpag.Data.Context
{
    public class MyContext : DbContext
    {
        public DbSet<UserEntity> Users { get; set; }
        public DbSet<ProductEntity> Products { get; set; }
        public MyContext(DbContextOptions<MyContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<UserEntity>(new UserMap().Configure);
            modelBuilder.Entity<ProductEntity>(new ProductMap().Configure);
        }
    }
}
