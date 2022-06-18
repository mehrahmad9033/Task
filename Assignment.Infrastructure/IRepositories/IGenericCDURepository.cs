using Common.SharedModels;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Infrastructure.IRepositories
{
    public interface IGenericCDURepository<T> where T : class
    {
        Task<ResponseObj> Add(T entity);
        Task<ResponseObj> Update(T entity);
        Task<ResponseObj> AddRange(IEnumerable<T> entities);
        Task<ResponseObj> Remove(int Key);
        Task<ResponseObj> RemoveRange(IEnumerable<T> entities);
    }
}