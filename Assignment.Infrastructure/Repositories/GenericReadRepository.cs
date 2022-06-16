using Assignment.Infrastructure.DB;
using Assignment.Infrastructure.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Assignment.Infrastructure.Repositories
{
    public class GenericReadRepository<T> : IGenericReadRepository<T> where T : class
    {
        protected readonly TaskContext _context;
        public GenericReadRepository(TaskContext context)
        {
            _context = context;
        }

        public IEnumerable<T> Find(Expression<Func<T, bool>> expression)
        {
            return _context.Set<T>().Where(expression);
        }

        public IEnumerable<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            return _context.Set<T>().Find(id);
        }
    }
}