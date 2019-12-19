using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace LUniversityNC19.Models
{
    public class LUniversityNC19Context : DbContext
    {
        public LUniversityNC19Context (DbContextOptions<LUniversityNC19Context> options)
            : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Address> Addresses { get; set; }
    }
}
