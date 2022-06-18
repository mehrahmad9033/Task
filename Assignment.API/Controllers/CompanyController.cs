using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment.Application.Features.Commands.Company.Create;
using Assignment.Application.Features.Commands.Company.Delete;
using Assignment.Application.Features.Commands.Company.Query;
using Assignment.Application.Features.Commands.Company.Update;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Assignment.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly ISender _mediator;

        public CompanyController(ISender mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("CreateCompany")]
        public async Task<ActionResult> CreateCompany([FromBody] CreateCompanyCommand command)
        { 
            return Ok(await _mediator.Send(command));
        }
        [HttpPost("UpdateCompany")]
        public async Task<ActionResult> UpdateCompany([FromBody] UpdateCompanyCommand command)
        {
            return Ok(await _mediator.Send(command));
        }
        [HttpPost("DeleteCompany")]
        public async Task<ActionResult> DeleteCompany([FromBody] DeleteCompanyCommand command)
        {
            return Ok(await _mediator.Send(command));
        }
        [HttpPost("GetCompanies")]
        public async Task<ActionResult> GetCompanies([FromBody] CompanyQueryCommand command)
        {
            return Ok(await _mediator.Send(command));
        }
    }
}