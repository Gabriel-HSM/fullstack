using Microsoft.EntityFrameworkCore;
using View.models;

namespace View.Data
{
    public class ProjetoModeloAppContext : DbContext
    {
        public ProjetoModeloAppContext(DbContextOptions<ProjetoModeloAppContext> options) : base (options){}

        public DbSet<Carro> Carro { get; set; }
        public DbSet<Marca> Marcas { get; set; }
        public DbSet<Motor> Motores { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Carro>()
                .HasOne(c => c.Marca)
                .WithMany()
                .HasForeignKey(c => c.MarcaId);

            modelBuilder.Entity<Carro>()
                .HasOne(c => c.Motor)
                .WithMany()
                .HasForeignKey(c => c.MotorId);
        }

    }
}