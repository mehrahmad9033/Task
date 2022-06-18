using Assignment.Domain.Modals;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment.Application.Features.Commands.Investor.Query
{
    public class QueryInvestorCommand : IRequest<List<Assignment.Domain.Modals.Investor>>
    {
    }
}
