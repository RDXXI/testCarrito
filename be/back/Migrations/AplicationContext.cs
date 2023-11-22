using back.Model;
using Microsoft.EntityFrameworkCore;

namespace back.Migrations
{
    public class AplicationContext : DbContext
    {
        public AplicationContext(DbContextOptions<AplicationContext> options)
        : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                   .SetBasePath(Directory.GetCurrentDirectory())
                   .AddJsonFile("appsettings.json")
                   .Build();
                var connectionString = configuration.GetConnectionString("DefaultConnection");
                optionsBuilder.UseSqlServer(connectionString);
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<PlanModel>().OwnsOne(x => x.ProductosPlan);

            base.OnModelCreating(modelBuilder);

        }

        public DbSet<PlanModel>  PlanModel { get; set; }
        public DbSet<ProductoModel> ProductoModel { get; set; }
        public DbSet<ProductoPlanModel> ProductoPlanModel { get; set; }
        public DbSet<UsuarioModel> UsuarioModel { get; set; }

    }
}
