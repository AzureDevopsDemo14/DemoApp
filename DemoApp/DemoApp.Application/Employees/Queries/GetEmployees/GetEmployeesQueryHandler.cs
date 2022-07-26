using AutoMapper;
using DemoApp.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using DemoApp.DbUpdate.Context;
using DemoApp.Application._extension;

namespace DemoApp.Application.Employees.Queries.GetEmployees
{
    public class GetEmployeesQueryHandler : IRequestHandler<GetEmployeesQuery, IEnumerable<Employee>>
    {
        //private readonly IMapper mapper;
        private readonly IDemoAppDbContext dbContext;
        public GetEmployeesQueryHandler(IMapper mapper, IDemoAppDbContext dbContext)
        {
            //this.mapper = mapper;
            this.dbContext = dbContext;
        }
        public async Task<IEnumerable<Employee>> Handle (GetEmployeesQuery request, CancellationToken cancellationToken)
        {
            var query = this.dbContext.Employees.OrderBy(x =>x.LastName);
            return await EfExtensions.ToListAsyncSafe<Employee>(query);
            //return this.mapper.Map<IEnumerable<EmployeeListItem>>(await query.ToListAsync(cancellationToken));
        }
    }
}
