using Assignment.Application.DTOS;
using Assignment.Domain.Modals;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment.Application.Features.Commands.Company.Query
{
    public class CompanyQueryCommand : IRequest<List<Companies>>
    {
    } 
}
