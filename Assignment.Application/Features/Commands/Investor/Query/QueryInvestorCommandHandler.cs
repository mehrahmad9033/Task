using Assignment.Application.IServices;
using Assignment.Domain.Modals;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Assignment.Application.Features.Commands.Investor.Query
{
    public class QueryInvestorCommandHandler : IRequestHandler<QueryInvestorCommand, List<Assignment.Domain.Modals.Investor>>
    {
        private readonly IInvestorService _Service;
        public QueryInvestorCommandHandler(IInvestorService _Service)
        {
            this._Service = _Service;
            //_mapper = mapper;
        }
        public async Task<List<Assignment.Domain.Modals.Investor>> Handle(QueryInvestorCommand request, CancellationToken cancellationToken)
        {
            return await _Service.GetInvestors();
        }

    }
}


