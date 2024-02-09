using crud_mvc.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace crud_mvc.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options)
        {
            
        }
        public DbSet<Student> Students { get; set; }
    }
}
