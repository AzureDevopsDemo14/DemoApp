using DemoApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp.Persistence.Context
{
    public interface IDemoAppDbContext
    {
        DbSet<Employee> Employees { get; set; }
    }
}
