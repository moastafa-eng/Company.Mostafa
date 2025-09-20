using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.Mostafa.DAL.Models;
using System.Reflection;

namespace Company.Mostafa.DAL.Data.Context
{
    public class CompanyDBContext : DbContext
    {

        public CompanyDBContext() : base()
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=Company.Mostafa;Trusted_Connection=True;TrustServerCertificate=True;");
        }

        public DbSet<Department> Departments { get; set; }
    }
}
