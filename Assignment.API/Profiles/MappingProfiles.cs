using Assignment.Application.DTOS;
using Assignment.Domain.Modals;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment.API.Profiles
{
    public class MappingProfiles:Profile
    {
        public MappingProfiles()
        {
            CreateMap<Companies, CompanyDTO>().ReverseMap();
        }
    }
}
