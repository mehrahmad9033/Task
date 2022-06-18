using Common.SharedModels;
using FluentValidation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment.Application.Features.Commands.Investor.Delete
{
    public class DeleteInvestorCommand : IRequest<ResponseObj>
    {
        public int CompanyID { get; set; }
        public string LoggedInUserId { get; set; }
    }
    public class DeleteInvestorCommandValidator : AbstractValidator<DeleteInvestorCommand>
    {
        public DeleteInvestorCommandValidator()
        {
            RuleFor(p => p.CompanyID)
                .NotNull().WithMessage("Investor ID is Required");
        }
    }
}
