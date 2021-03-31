using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace StudentProgress.Models
{
    public class StudentContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        //public DbSet<Discipline> Discipline { get; set; }
        //public DbSet<Progress> Progress { get; set; }
    }
}