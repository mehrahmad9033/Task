using Assignment.Infrastructure.DB;
using Assignment.Infrastructure.IRepositories; 
using Common.SharedModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Infrastructure.Repositories
{
    public class GenericCDURepository<T> : IGenericCDURepository<T> where T : class
    {
        protected readonly TaskContext _context;
        public GenericCDURepository(TaskContext context)
        {
            _context = context;
        }

        public async Task<ResponseObj> Add(T entity)
        {
            try
            {
                _context.Set<T>().Add(entity);
                return new ResponseObj()
                {
                    Status = true,
                    Description = "Completed"
                };
            }
            catch (Exception ex)
            {
                return new ResponseObj()
                {
                    Description = ex.Message,
                    Status = false
                };
            }
             
        }

        public async Task<ResponseObj> AddRange(IEnumerable<T> entities)
        {
            try
            {
                _context.Set<T>().AddRange(entities);
                return new ResponseObj()
                {
                    Status = true,
                    Description = "Completed"
                };
            }
            catch (Exception ex)
            {
                return new ResponseObj()
                {
                    Description = ex.Message,
                    Status = false
                };
            }
           
        }

        public async Task<ResponseObj> Remove(T entity)
        {
            try
            {
                _context.Set<T>().Remove(entity);
                return new ResponseObj()
                {
                    Status = true,
                    Description = "Completed"
                };
            }
            catch (Exception ex)
            {
                return new ResponseObj()
                {
                    Description = ex.Message,
                    Status = false
                };
            }
           
        }

        public async Task<ResponseObj> RemoveRange(IEnumerable<T> entities)
        {
            try
            {
                _context.Set<T>().RemoveRange(entities);
                return new ResponseObj()
                {
                    Status = true,
                    Description = "Completed"
                };
            }
            catch (Exception ex)
            {
                return new ResponseObj()
                {
                    Description = ex.Message,
                    Status = false
                };
            }
           
        }

        public async Task<ResponseObj> Update(T entity)
        {
            try
            {
                T existing = _context.Set<T>().Find(entity);
                if (existing != null)
                {
                    _context.Entry(existing).CurrentValues.SetValues(entity);
                    _context.SaveChanges();
                }

                return new ResponseObj()
                {
                    Status = true,
                    Description = "Completed"
                };
            }
            catch (Exception ex)
            {
                return new ResponseObj()
                {
                    Description = ex.Message,
                    Status = false
                };
            }
        }
    }
}