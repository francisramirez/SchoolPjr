using Microsoft.EntityFrameworkCore;
using SchoolPjr.DAL.Entities;


namespace SchoolPjr.DAL
{
    public class SchoolContext : DbContext
    {

        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)
        {

        }

        public DbSet<Department> Departments { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<StudentGrade> StudentGrades { get; set; }
    } 
}
