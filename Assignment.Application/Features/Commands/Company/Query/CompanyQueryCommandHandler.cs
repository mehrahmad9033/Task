using Assignment.Application.IServices;
using Assignment.Domain.Modals;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Assignment.Application.Features.Commands.Company.Query
{
   public class CompanyQueryCommandHandler : IRequestHandler<CompanyQueryCommand, List<Companies>>
    {
        private readonly ICompanyService _companyService;
        public CompanyQueryCommandHandler(ICompanyService _companyService)
        {
            this._companyService = _companyService;
            //_mapper = mapper;
        }
        public async Task<List<Companies>> Handle(CompanyQueryCommand request, CancellationToken cancellationToken)
        {
            return await _companyService.GetCompanies();
        }

    }
}


