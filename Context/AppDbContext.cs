using Microsoft.EntityFrameworkCore;
using WebTrader.Models;

namespace WebTrader.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Lanche> Lanches { get; set; }
        public DbSet<T_Tipo_Contato> T_Tipos_Contato { get; set; }        
        public DbSet<T_Contato> T_Contatos { get; set; }
        public DbSet<T_Usuario> T_Usuarios { get; set; }
        public DbSet<T_Proposta_Negociacao> T_Propostas_Negociacao { get; set; }
        
        
    }
}
