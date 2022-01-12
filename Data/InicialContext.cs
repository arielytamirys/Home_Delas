using NewJob.Models;
using Microsoft.EntityFrameworkCore;

namespace NewJob.Data
{
    public class InicialContext : DbContext 
    {
        public InicialContext(DbContextOptions<InicialContext> opt) : base(opt) {

        }
        public DbSet<Inicial> Inicials {get; set;}
        public DbSet<Vaga> Vagas {get; set;}
        public DbSet<Link_Curso> Link_Cursos {get; set;}
        public DbSet<Login> Logins {get; set;}
        public DbSet<Contato> Contatos {get; set;}
    }
}