using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Assignment.Infrastructure.IRepositories
{
    public interface IGenericReadRepository<T> where T : class
    {
        T GetById(int id);
        IEnumerable<T> GetAll();
        IEnumerable<T> Find(Expression<Func<T, bool>> expression);
    }
}
