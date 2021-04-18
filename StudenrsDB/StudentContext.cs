using System.Data.Entity;

namespace StudenrsDB
{
    public class StudentContext : DbContext
    {
        public StudentContext() : base("ConnectToStudentDB") { }
        public DbSet<Student> Students { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Specialty> Specialties { get; set; }
    }
}
