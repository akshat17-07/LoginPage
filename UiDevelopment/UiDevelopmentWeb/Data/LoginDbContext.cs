using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using UiDevelopmentWeb.Models;

namespace UiDevelopmentWeb.Data
{
    public class LoginDbContext : DbContext
    {

        public LoginDbContext(DbContextOptions<LoginDbContext> options) : base(options) { }
        public DbSet<LoginModel> UserDetail {get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<LoginModel>(entity => {
                entity.HasKey(k => k.email);
            });
        }
    }
}
