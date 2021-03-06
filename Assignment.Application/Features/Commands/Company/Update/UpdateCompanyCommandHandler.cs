using Assignment.Application.DTOS;
using Assignment.Application.IServices;
using Common.SharedModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Assignment.Application.Features.Commands.Company.Update
{
    public class UpdateCompanyCommandHandler : IRequestHandler<UpdateCompanyCommand, ResponseObj>
    {
        private readonly ICompanyService _companyService;
        public UpdateCompanyCommandHandler(ICompanyService _companyService)
        {
            this._companyService = _companyService;
            //_mapper = mapper;
        }
        public async Task<ResponseObj> Handle(UpdateCompanyCommand request, CancellationToken cancellationToken)
        {
            return await _companyService.UpdateCompany(request);
        }
    }
}


