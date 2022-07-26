using DemoApp.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoApp.Application.Employees.Queries.GetEmployees
{
    public class GetEmployeesQuery : IRequest<IEnumerable<Employee>>
    {
    }
}
