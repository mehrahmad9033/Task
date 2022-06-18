using Assignment.Application.DTOS;
using Assignment.Application.IServices;
using Assignment.Domain.Modals;
using Assignment.Infrastructure.IRepositories;
using AutoMapper;
using Common.SharedModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Application.Services
{
    public class InvestorService : IInvestorService
    {
        private readonly IMapper _mapper;
        private readonly IGenericCDURepository<Investor> _repo;
        private readonly IGenericReadRepository<Investor> _repo_Read;
        public InvestorService(
            IGenericCDURepository<Investor> repo, 
            IMapper mapper, 
            IGenericReadRepository<Investor> _repo_Read)
        {
            this._repo = repo;
            _mapper = mapper;
            this._repo_Read = _repo_Read;
        }
        public async Task<ResponseObj> DeleteInvestor(int Key)
        {
            return await _repo.Remove(Key);
        }

        public async Task<List<Investor>> GetInvestors()
        {
            return await _repo_Read.GetAll();
        }

        public async Task<ResponseObj> SaveInvestor(InvestorDTO obj)
        {
            return await _repo.Add(_mapper.Map<Investor>(obj));
        }

        public async Task<ResponseObj> UpdateInvestor(InvestorDTO obj)
        {
            return await _repo.Update(_mapper.Map<Investor>(obj));
        }
    }
}
