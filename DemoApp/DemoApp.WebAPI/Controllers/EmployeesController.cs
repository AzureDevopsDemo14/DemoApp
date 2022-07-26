using DemoApp.Application.Employees.Queries.GetEmployees;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;

namespace DemoApp.WebAPI.Controllers
{
    [EnableCors("AllowOrigin")]
    public class EmployeesController : ApiControllerBase
    {

        [HttpGet]
        //[AllowAnonymous]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult> Get()
        {
            var data = await Mediator.Send(new GetEmployeesQuery());
            return Ok(data);
        }
    }
}
