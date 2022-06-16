using Assignment.Application.DTOS;
using Assignment.Application.IServices;
using Assignment.Infrastructure.IRepositories;
using Assignment.Infrastructure.Repositories;
using Common.SharedModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Application.Services
{
    public class CompanyService : ICompanyService
    {
        private readonly IGenericCDURepository<CompanyDTO> _repo;
        public CompanyService(GenericCDURepository<CompanyDTO> repo)
        {
            this._repo = repo;
        }

        public async  Task<ResponseObj> DeleteCompany(CompanyDTO CompanyID)
        {
            return await _repo.Remove(CompanyID);
        }

        public async Task<ResponseObj> SaveCompanyr(CompanyDTO obj)
        {
            return await _repo.Add(obj);
        }

        public async Task<ResponseObj> UpdateCompany(CompanyDTO obj)
        {
            return await _repo.Update(obj);
        }
    }
}
