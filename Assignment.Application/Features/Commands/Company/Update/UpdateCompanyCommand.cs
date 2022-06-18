using Assignment.Application.DTOS;
using Common.SharedModels;
using FluentValidation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment.Application.Features.Commands.Company.Update
{
    public class UpdateCompanyCommand : CompanyDTO, IRequest<ResponseObj>
    { 
    }
    public class UpdateCompanyCommandValidator : AbstractValidator<CompanyDTO>
    {
        public UpdateCompanyCommandValidator()
        {
            RuleFor(p => p.CompanyID)  
                   .NotNull().WithMessage("Company ID is Required");

            RuleFor(p => p.CompanyName)
                .NotEmpty().WithMessage("Company Name is Required")
                .MinimumLength(10).WithMessage("Minimum length of company name is 10.")
                .NotNull().WithMessage("Company Name is Required");
        }
    }
}
