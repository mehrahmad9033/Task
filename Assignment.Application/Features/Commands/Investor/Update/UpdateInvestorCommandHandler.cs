using Assignment.Application.IServices;
using Common.SharedModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Assignment.Application.Features.Commands.Investor.Update
{
    public class UpdateInvestorCommandHandler : IRequestHandler<UpdateInvestorCommand, ResponseObj>
    {
        private readonly IInvestorService _companyService;
        public UpdateInvestorCommandHandler(IInvestorService _companyService)
        {
            this._companyService = _companyService;
            //_mapper = mapper;
        }
        public async Task<ResponseObj> Handle(UpdateInvestorCommand request, CancellationToken cancellationToken)
        {
            return await _companyService.UpdateInvestor(request);
        }
    }
}


