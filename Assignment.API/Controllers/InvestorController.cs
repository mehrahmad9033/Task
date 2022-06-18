using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment.Application.Features.Commands.Investor.Create;
using Assignment.Application.Features.Commands.Investor.Delete;
using Assignment.Application.Features.Commands.Investor.Query;
using Assignment.Application.Features.Commands.Investor.Update;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Assignment.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvestorController : ControllerBase
    {
        private readonly ISender _mediator;

        public InvestorController(ISender mediator)
        {
            _mediator = mediator;
        }
        [HttpPost("CreateIInvestor")]
        public async Task<ActionResult> CreateIInvestor([FromBody] CreateInvestorCommand command)
        {
            return Ok(await _mediator.Send(command));
        }
        [HttpPost("UpdateInvestor")]
        public async Task<ActionResult> UpdateInvestor([FromBody] UpdateInvestorCommand command)
        {
            return Ok(await _mediator.Send(command));
        }
        [HttpPost("DeleteInvestor")]
        public async Task<ActionResult> DeleteInvestor([FromBody] DeleteInvestorCommand command)
        {
            return Ok(await _mediator.Send(command));
        }
        [HttpPost("GetInvestors")]
        public async Task<ActionResult> GetInvestors([FromBody] QueryInvestorCommand command)
        {
            return Ok(await _mediator.Send(command));
        }
    }
}