using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment.Application.Features.Commands.Company.Create;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Assignment.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CompanyController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("CreateCompany")]
        public async Task<ActionResult> CreateCompany([FromBody] CreateCompanyCommand command)
        { 
            return Ok(await _mediator.Send(command));
        }
    }
}