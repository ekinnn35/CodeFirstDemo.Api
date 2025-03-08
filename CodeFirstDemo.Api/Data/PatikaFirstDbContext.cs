using Microsoft.EntityFrameworkCore;
using CodeFirstDemo.Api.Entities;

namespace CodeFirstDemo.Api.Data
{
    public class PatikaFirstDbContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Game> Games { get; set; }

        public PatikaFirstDbContext(DbContextOptions<PatikaFirstDbContext> options) : base(options)
        {
        }
    }
}
