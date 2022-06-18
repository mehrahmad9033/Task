using Assignment.Application.DTOS;
using Common.SharedModels;
using FluentValidation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment.Application.Features.Commands.Company.Create
{
    public class CreateCompanyCommand : CompanyDTO,IRequest<ResponseObj>
    {
        public string LoggedInUserId { get; set; }
    }
    public class CreateCompanyCommandValidator : AbstractValidator<CreateCompanyCommand>
    {
        public CreateCompanyCommandValidator()
        {
            RuleFor(p => p.CompanyName)
                .NotEmpty().WithMessage("Company Name is Required")
                .MinimumLength(10).WithMessage("Minimum length of company name is 10.")
                .NotNull().WithMessage("Company Name is Required");
        }
    }
}
