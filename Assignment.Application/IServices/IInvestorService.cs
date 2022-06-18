using Assignment.Application.DTOS;
using Assignment.Domain.Modals;
using Common.SharedModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Application.IServices
{
    public interface IInvestorService
    {
        Task<ResponseObj> SaveInvestor(InvestorDTO obj);
        Task<ResponseObj> UpdateInvestor(InvestorDTO obj);
        Task<ResponseObj> DeleteInvestor(int Key);
        Task<List<Investor>> GetInvestors();
    }
}
