using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Application.IServices
{
    public interface IInvestorService
    {
        Task<string> SaveInvestor();
        Task<string> UpdateInvestor();
        Task<string> DeleteInvestor();
    }
}
