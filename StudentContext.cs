using Microsoft.EntityFrameworkCore;

namespace StudentManagement
{
    public class StudentContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=OkanStudentDB;Trusted_Connection=True;");
        }
    }
}