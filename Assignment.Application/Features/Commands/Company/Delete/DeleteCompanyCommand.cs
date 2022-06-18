using Assignment.Application.DTOS;
using Common.SharedModels;
using FluentValidation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment.Application.Features.Commands.Company.Delete
{
    public class DeleteCompanyCommand :  IRequest<ResponseObj>
    {
        public int CompanyID { get; set; }
        public string LoggedInUserId { get; set; }
    }
    public class DeleteCompanyCommandValidator : AbstractValidator<DeleteCompanyCommand>
    {
        public DeleteCompanyCommandValidator()
        {
            RuleFor(p => p.CompanyID)  
                .NotNull().WithMessage("Company ID is Required");
        }
    }
}
