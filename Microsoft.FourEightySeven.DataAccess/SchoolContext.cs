﻿using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Microsoft.FourEightySeven.DataModel;

namespace Microsoft.FourEightySeven.DataAccess
{
    public class SchoolContext : DbContext
    {
    
        public SchoolContext() : base("SchoolContext")
        {
        }
        
        public DbSet<Student> Students { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Course> Courses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
