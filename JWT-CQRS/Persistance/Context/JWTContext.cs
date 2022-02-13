using JWT_CQRS.Core.Domain;
using JWT_CQRS.Persistance.Configurations;
using Microsoft.EntityFrameworkCore;

namespace JWT_CQRS.Persistance.Context
{
    public class JWTContext : DbContext
    {
        public JWTContext(DbContextOptions<JWTContext> options) : base(options)
        {

        }
        public DbSet<Category> Categories => this.Set<Category>();
       
        public DbSet<Product> Products => this.Set<Product>();
      
        public DbSet<User> Users => this.Set<User>();
            
        public DbSet<Role> Roles => this.Set<Role>();
      
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            base.OnModelCreating(modelBuilder);
        }

    }
}
