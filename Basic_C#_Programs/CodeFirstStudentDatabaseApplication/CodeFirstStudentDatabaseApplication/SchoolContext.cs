using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstStudentDatabaseApplication
{
    public class SchoolContext : DbContext
    {
        public SchoolContext() : base() //this is a constructor that calls the base class constructor that is defined in the DbContext class and is empty
        {

        }

        public DbSet<Student> Students { get; set; } //this is a DbSet property that represents a collection of entities
        public DbSet<Grade> Grades { get; set; } //this is a DbSet property that represents a collection of entities
    }
}
