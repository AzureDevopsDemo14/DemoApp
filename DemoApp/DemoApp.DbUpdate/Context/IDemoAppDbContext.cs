using DemoApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoApp.DbUpdate.Context
{
    public interface IDemoAppDbContext
    {
        DbSet<Employee> Employees { get; set; }
    }
}
