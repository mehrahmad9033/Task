using Assignment.Application.DTOS;
using Assignment.Domain.Modals;
using Common.SharedModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Application.IServices
{
    public interface ICompanyService
    {
        Task<ResponseObj> SaveCompanyr(CompanyDTO obj);
        Task<ResponseObj> UpdateCompany(CompanyDTO obj);
        Task<ResponseObj> DeleteCompany(int CompanyID);
        Task<List<Companies>> GetCompanies();
    }
}
