using Microsoft.EntityFrameworkCore;
using IceTask3.Data;
using IceTask3.Models;

namespace IceTask3.Data
{
    public class StudentContext : DbContext
    {
        public StudentContext(DbContextOptions<StudentContext> options) : base(options) { }

        public DbSet<Student> Student { get; set; }
        public DbSet<Course> Course { get; set; }
    }
}
