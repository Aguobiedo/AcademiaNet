using ApiAcademia.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiAcademia.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions <AppDbContext>options) : base(options) { }

        public DbSet<Alumno> alumnos {  get; set; } 
    }
}
