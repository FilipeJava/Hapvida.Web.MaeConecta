using Hapvida.Web.MaeConecta.Models;
using Microsoft.EntityFrameworkCore;

namespace Hapvida.Web.MaeConecta.Persistencia
{

    
    public class MaeContext : DbContext
    {

        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Ocorrencias> Ocorrencias { get; set;}
        
        public DbSet<Procedimentos> Procedimentos { get; set; }

        public DbSet<Contatos> Contatos { get; set; }

        public DbSet<Endereco> Endereco { get; set; }

        public MaeContext(DbContextOptions options ):base(options) { }


    }
}
