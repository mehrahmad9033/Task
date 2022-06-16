using Assignment.Application.DTOS;
using FluentValidation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment.Application.Features.Commands.Investor.Create
{
    public class CreateInvestorCommand : InvestorDTO, IRequest<List<InvestorDTO>>
    {
    }
    public class CreateInvestorCommandValidator : AbstractValidator<InvestorDTO>
    {
        public CreateInvestorCommandValidator()
        {
            RuleFor(p => p.InvestorName)
                .NotEmpty().WithMessage("Investor Name is Required")
                .MinimumLength(10).WithMessage("Minimum length of Investor name is 10.")
                .NotNull().WithMessage("Investor Name is Required");

            RuleFor(p => p.ContactNo)
                            .NotEmpty().WithMessage("ContactNo Name is Required")
                            .MinimumLength(10).WithMessage("Minimum length of ContactNo  is 10.")
                            .NotNull().WithMessage("ContactNo Name is Required");

            RuleFor(p => p.Address)
                            .NotEmpty().WithMessage("Address is Required")
                            .MinimumLength(10).WithMessage("Minimum length of Address is 10.")
                            .NotNull().WithMessage("Address Name is Required");

            RuleFor(p => p.City)
                            .NotEmpty().WithMessage("City is Required")
                            .MinimumLength(10).WithMessage("Minimum length of City is 10.")
                            .NotNull().WithMessage("City is Required");

            RuleFor(p => p.ShareValue)  
                            .NotNull().WithMessage("Share value is Required");

            RuleFor(p => p.SharePrice)
                            .NotNull().WithMessage("Share Pirce is Required");

            RuleFor(p => p.ShareQTY)
                                       .NotNull().WithMessage("ShareQTY is Required");

            RuleFor(p => p.CompanyID).NotNull().WithMessage("CompanyID is Required");

            RuleFor(p => p.Email)
                            .NotEmpty().WithMessage("Email is Required")
                            .NotNull().WithMessage("Email is Required");
        }
    }
}
