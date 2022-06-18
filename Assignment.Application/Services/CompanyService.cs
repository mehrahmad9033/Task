using Assignment.Application.DTOS;
using Assignment.Application.IServices;
using Assignment.Domain.Modals;
using Assignment.Infrastructure.IRepositories;
using Assignment.Infrastructure.Repositories;
using AutoMapper;
using Common.SharedModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Application.Services
{
    public class CompanyService : ICompanyService
    {
        private readonly IMapper _mapper;
        private readonly IGenericCDURepository<Companies> _repo; 
        private readonly IGenericReadRepository<Companies> _repo_Read;
        public CompanyService(IGenericCDURepository<Companies> repo, IMapper mapper, IGenericReadRepository<Companies> _repo_Read)
        {
            this._repo = repo;
            _mapper = mapper;
            this._repo_Read = _repo_Read;
        }

        public async  Task<ResponseObj> DeleteCompany(int obj)
        {
            return await _repo.Remove(obj);
        }

        public async Task<List<Companies>> GetCompanies()
        {
            return await _repo_Read.GetAll();
        }

        public async Task<ResponseObj> SaveCompanyr(CompanyDTO obj)
        { 
            return await _repo.Add(_mapper.Map<Companies>(obj));
        }

        public async Task<ResponseObj> UpdateCompany(CompanyDTO obj)
        { 
            return await _repo.Update(_mapper.Map<Companies>(obj));
        }
         
    }
}
