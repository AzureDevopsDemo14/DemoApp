using DemoApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoApp.Persistence.Context
{
    public class DemoAppDbContext : DbContext, IDemoAppDbContext 
    {
        public DbSet<Employee> Employees { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=CBEN-3JFZ3D3-LX;Database=DemoAppDB;Trusted_Connection=True;MultipleActiveResultSets=true");
        }
    }
}
