using Assignment.Application.IServices;
using Common.SharedModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Assignment.Application.Features.Commands.Company.Delete
{
    public class DeleteCompanyCommandHandler : IRequestHandler<DeleteCompanyCommand, ResponseObj>
    {
        private readonly ICompanyService _companyService;
        public DeleteCompanyCommandHandler(ICompanyService _companyService)
        {
            this._companyService = _companyService;
            //_mapper = mapper;
        }
        public async Task<ResponseObj> Handle(DeleteCompanyCommand request, CancellationToken cancellationToken)
        {
            return await _companyService.DeleteCompany(request.CompanyID);
        }
         
    }
}


