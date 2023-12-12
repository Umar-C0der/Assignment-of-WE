using Microsoft.EntityFrameworkCore;

namespace Assignment.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
       : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Faculty> Faculties { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Enrolled> Enrollments { get; set; }
    }
}
