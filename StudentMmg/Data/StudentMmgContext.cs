using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StudentMmg.Models;

namespace StudentMmg.Data
{
    public class StudentMmgContext : DbContext
    {
        public StudentMmgContext (DbContextOptions<StudentMmgContext> options)
            : base(options)
        {
        }

        public DbSet<StudentMmg.Models.Student> Student { get; set; }

        public DbSet<StudentMmg.Models.Course> Course { get; set; }

        public DbSet<StudentMmg.Models.Enrol> Enrol { get; set; }
    }
}
