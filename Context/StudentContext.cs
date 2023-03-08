using Microsoft.EntityFrameworkCore;
using studentsAPI.Models.Entities;

namespace studentsAPI.Context
{
    public class StudentContext : DbContext
    {
       public StudentContext(DbContextOptions<StudentContext> options) : base(options)
        {

        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<SchoolSubject> SchoolSubjects { get; set; }
        public DbSet<Classroom> Classrooms { get; set; }
    }
}