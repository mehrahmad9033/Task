using Assignment.Application.IServices;
using Common.SharedModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Assignment.Application.Features.Commands.Investor.Create
{
    public class CreateInvestorCommandHandler : IRequestHandler<CreateInvestorCommand, ResponseObj>
    {
        private readonly IInvestorService _companyService;
        public CreateInvestorCommandHandler(IInvestorService _companyService)
        {
            this._companyService = _companyService;
            //_mapper = mapper;
        }
        public async Task<ResponseObj> Handle(CreateInvestorCommand request, CancellationToken cancellationToken)
        {
            return await _companyService.SaveInvestor(request);
        } 
    }
}


