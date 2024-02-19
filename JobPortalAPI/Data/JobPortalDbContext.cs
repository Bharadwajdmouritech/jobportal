using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JobPortalAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace JobPortalAPI.Data
{
    public class JobPortalDbContext:DbContext
    {
        public JobPortalDbContext()
        {
        }

        public JobPortalDbContext(DbContextOptions<JobPortalDbContext> options)
            : base(options)
        {
            
        }

        public virtual DbSet<Admin> Admins { get; set; }

        public virtual DbSet<City> Cities { get; set; }

        public virtual DbSet<Designation> Designations { get; set; }

        public virtual DbSet<EmployeeInfo> EmployeeInfos { get; set; }
        public virtual DbSet<EmployeeDocument> EmployeeDocuments { get; set; }

        public virtual DbSet<JobDescription> JobDescriptions { get; set; }

        public virtual DbSet<Roles> Roles { get; set; }

            
    }
}