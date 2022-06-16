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
         

        //Task<CompanyDTO> Handle(CreateCompanyCommand request, CancellationToken cancellationToken)
        //{
        //    //var submisResponse = new InvestorValidationError<List<CompanyDTO>>();
        //    //List<ScheduleValidationError> validationErrorsList = new List<ScheduleValidationError>();
        //    ////----------------------------------Checking Existing Investor
        //    //if (await _scheduleService.ValidateExistingSchedule(request.SCHEDULE_NAME) > 0)
        //    //{
        //    //    validationErrorsList.Add(new ScheduleValidationError(
        //    //        "Investor Name", "Schedule already exists"));
        //    //}
        //    //var submisDto = _mapper.Map<COLLATERAL_SCHEDULES_DTO>(request);
        //    //if (validationErrorsList.Count > 0)
        //    //{
        //    //    var validateionErrResponse = new Collateral_Schedule_R
        //    //return submisResponse;
        //    throw new NotImplementedException();
        //}

        public async Task<ResponseObj> Handle(CreateCompanyCommand request, CancellationToken cancellationToken)
        {
             return await _companyService.SaveCompanyr(request);
        }
    }
}


