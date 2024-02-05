using Chapter.Models;
using Microsoft.EntityFrameworkCore;

namespace Chapter.Contexts
{
    public class ChapterContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //cada provedor tem sua sintaxe
                optionsBuilder.UseSqlServer("Data Source = DESKTOP-AP18MAI\\SQLEXPRESS; initial catalog = Chapter; Integrated Security = true;  TrustServerCertificate = True");

            }
        }

        //entidade que vamos usar:
        public DbSet<Livro> Livros { get; set; }
    }
}
