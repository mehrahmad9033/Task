using Assignment.Infrastructure.DB;
using Assignment.Infrastructure.IRepositories; 
using Common.SharedModels;
using Microsoft.EntityFrameworkCore;
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
                _context.SaveChanges();
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
                _context.SaveChanges();
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

        public async Task<ResponseObj> Remove(int Key)
        {
            try
            {
                var entity = await _context.Set<T>().FindAsync(Key);
                if (entity == null)
                {
                    return new ResponseObj()
                    {
                        Description = "Data object not available",
                        Status = false
                    };
                }
                _context.Set<T>().Remove(entity); 
                _context.SaveChanges();
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
                _context.SaveChanges();
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
                _context.Entry(entity).State = EntityState.Modified;
                await _context.SaveChangesAsync();

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