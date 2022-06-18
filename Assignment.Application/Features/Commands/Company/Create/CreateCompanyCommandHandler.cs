using Assignment.Application.DTOS;
using Assignment.Application.IServices;
using Assignment.Infrastructure.IRepositories;
using Common.SharedModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Assignment.Application.Features.Commands.Company.Create
{
    public class CreateCompanyCommandHandler : IRequestHandler<CreateCompanyCommand, ResponseObj>
    {
        private readonly ICompanyService _companyService;
        public CreateCompanyCommandHandler(ICompanyService _companyService )
        {
            this._companyService = _companyService;
            //_mapper = mapper;
        }  
        public async Task<ResponseObj> Handle(CreateCompanyCommand request, CancellationToken cancellationToken)
        {
             return await _companyService.SaveCompanyr(request);
        }
    }
}


