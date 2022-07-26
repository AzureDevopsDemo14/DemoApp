using AutoMapper;
using DemoApp.Application._Interfaces.Mapping;
using DemoApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoApp.Application.Employees.Queries.GetEmployees
{
    public class EmployeeListItem : IHaveCustomMapping
    {
        public int EmployeeId { get; set; }
        public string EmployeeNo { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public void CreateMappings(Profile configuration)
        {
            configuration.CreateMap<Employee, EmployeeListItem>();
        }
    }
}
