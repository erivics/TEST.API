using Microsoft.EntityFrameworkCore;
using TEST.API.Entity;

namespace TEST.API.DB
{
    public class StudentDbContext : DbContext
    {
        //private string _conn {get; set;}

        // public StudentDbContext(IConfiguration config)
        // {
        //     _conn = config.GetConnectionString("StudentDB");
        // }
        public StudentDbContext(DbContextOptions<StudentDbContext> options) : base(options)
        {
            
        }

        public DbSet<Student> Student {get; set;}

        // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        // {
        //     optionsBuilder.UseSqlServer(_conn);
        // }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            this.SeedStudent(builder);
        }

        private void SeedStudent(ModelBuilder builder)
        {
            Student[] student = new Student[] {
            new Student { Id = 1, FirstName = " Kolawole", LastName = " Adebayo", CreateAt = DateTimeOffset.Now },
            new Student { Id = 2, FirstName = " Olawole", LastName = " George", CreateAt = DateTimeOffset.Now }
        };

        builder.Entity<Student>().HasData(student);
        }
    }

    
}