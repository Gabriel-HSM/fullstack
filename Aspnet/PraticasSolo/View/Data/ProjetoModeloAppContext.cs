using Microsoft.EntityFrameworkCore;
using View.models;

namespace View.Data
{
    public class ProjetoModeloAppContext : DbContext
    {
        public ProjetoModeloAppContext(DbContextOptions<ProjetoModeloAppContext> options) : base (options){}

        public DbSet<Carro> Carro { get; set; }
    }
}