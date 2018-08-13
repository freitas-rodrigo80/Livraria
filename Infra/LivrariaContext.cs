using Livraria.Models;
using System.Data.Entity;

namespace Livraria.Infra
{
    public class LivrariaContext : DbContext
    {
        public LivrariaContext() : base("name=livraria")
        {

        }
        public DbSet<Livro> Livros { get; set; }

    }
}