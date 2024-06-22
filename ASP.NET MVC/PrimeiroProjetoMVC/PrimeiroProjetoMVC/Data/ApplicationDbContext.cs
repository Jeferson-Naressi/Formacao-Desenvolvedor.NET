using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PrimeiroProjetoMVC.Models;

namespace PrimeiroProjetoMVC.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<PrimeiroProjetoMVC.Models.Aluno> Aluno { get; set; } = default!;
    }
}
