using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace StdMgtSystem.Models
{
    public partial class StudentSystemContext : DbContext
    {
        public StudentSystemContext()
        {
        }

        public StudentSystemContext(DbContextOptions<StudentSystemContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Students> Student { get; set; } = null!;

        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Students>()
            .HasKey(s => s.StudentId);

            modelBuilder.Entity<Students>().HasData(
            
               new Students
               {
                   StudentId=109,
                   Name="ABDUL MAJEED",
                   Branch="CS",
                   Section="D",
                   Gender="Male"
               }
            
            );

            
        }

        
    }
}
