using Microsoft.EntityFrameworkCore;

namespace AlwaysOn.API
{
    public class DBcontextAO:DbContext
    {
        public DBcontextAO(DbContextOptions<DBcontextAO> options):base(options)
        {
            
        }
        public DbSet<Productos> Productos { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
          
            builder.Entity<Productos>(o => o.HasKey(o => o.Id));
            base.OnModelCreating(builder);
        }
    }
}
