using FluentValidationExample.Entities;
using Microsoft.EntityFrameworkCore;

namespace FluentValidationExample.Data
{
    public class StudentContext:DbContext
    {
        public DbSet<Student>Students { get; set; }
        public StudentContext(DbContextOptions<StudentContext> options):base(options)
        {

        }
    }
}
