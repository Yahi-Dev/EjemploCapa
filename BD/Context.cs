using Entidades;
using Microsoft.EntityFrameworkCore;

namespace BD
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) { }

        public DbSet<Carro> Carro { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Carro>().HasKey(k => k.Id);
        }
    }
}
