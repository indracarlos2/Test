using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
namespace RestorationStore.Domain.Abstract {
    public interface IRepository <T> where T: class{
        IQueryable<T> AsQueryable();
        IEnumerable<T> FindAll();
        IEnumerable<T> Find(Expression<Func<T, bool>> predicate);
        T FindOne(Expression<Func<T, bool>> predicate);
        T FindOneForId(int id);
        void Add(T entity);
        void Edit(T entity);
        void Delete(T entity);
        void Save();
    }
}
