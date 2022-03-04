using Microsoft.EntityFrameworkCore;
using MMMMedia.EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MMMMedia.EF.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {

        }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public virtual DbSet<EmployeeMaster> EmployeeMaster { get; set; }
        public virtual DbSet<DesignationMaster> DesignationMaster { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<EmployeeMaster>()
                .HasIndex(u => u.Email)
                .IsUnique();
            builder.Entity<EmployeeMaster>()
                .HasIndex(u => u.EmployeeNo)
                .IsUnique();
            builder.Entity<EmployeeMaster>()
                .HasIndex(u => u.Mobile)
                .IsUnique();
        }
    }
}
