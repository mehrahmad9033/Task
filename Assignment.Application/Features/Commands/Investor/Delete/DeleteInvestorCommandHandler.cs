using Assignment.Application.IServices;
using Common.SharedModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Assignment.Application.Features.Commands.Investor.Delete
{
    public class DeleteInvestorCommandHandler : IRequestHandler<DeleteInvestorCommand, ResponseObj>
    {
        private readonly ICompanyService _companyService;
        public DeleteInvestorCommandHandler(ICompanyService _companyService)
        {
            this._companyService = _companyService;
            //_mapper = mapper;
        }
        public async Task<ResponseObj> Handle(DeleteInvestorCommand request, CancellationToken cancellationToken)
        {
            return await _companyService.DeleteCompany(request.CompanyID);
        }

    }
}


