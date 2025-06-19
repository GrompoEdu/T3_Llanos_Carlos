
using Microsoft.EntityFrameworkCore;
using T3_Llanos_Carlos.Models;

namespace T3_Llanos_Carlos.Datos
{
    public class ApplicationDbContext:DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Libro>Libro { get; set; }

    }
}
