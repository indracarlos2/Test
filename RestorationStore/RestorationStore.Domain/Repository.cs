using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestorationStore.Domain.Abstract;
using System.Data.Entity;
using RestorationStore.Domain.Model;
namespace RestorationStore.Domain {
    public class Repository<T> : IRepository<T>, IDisposable where T : class{
        private readonly DbContext _context;

        public Repository() {
            _context = new RestorationStoreBDEntities();
        }
        public IQueryable<T> AsQueryable() {
            return _context.Set<T>().AsQueryable();
        }

        public IEnumerable<T> FindAll() {
            return _context.Set<T>();
        }

        public IEnumerable<T> Find(System.Linq.Expressions.Expression<Func<T, bool>> predicate) {
            return _context.Set<T>().Where(predicate);
        }

        public T FindOne(System.Linq.Expressions.Expression<Func<T, bool>> predicate) {
            return _context.Set<T>().Where(predicate).FirstOrDefault();
        }

        public T FindOneForId(int id) {
            return _context.Set<T>().Find(id);
        }

        public void Add(T entity) {
            if(_context.Entry<T>(entity).State !=
                 System.Data.EntityState.Detached)
                _context.Entry<T>(entity).State = System.Data.EntityState.Added;
            {
                _context.Set<T>().Add(entity);
            }
        }

        public void Edit(T entity) {
            if(_context.Entry<T>(entity).State == System.Data.EntityState.Detached) {
                _context.Set<T>().Attach(entity);
            }
            _context.Entry<T>(entity).State = System.Data.EntityState.Modified;
        }

        public void Delete(T entity) {
            if(_context.Entry<T>(entity).State == System.Data.EntityState.Detached) {
                _context.Set<T>().Attach(entity);
            }
            _context.Entry<T>(entity).State = System.Data.EntityState.Deleted;
        }

        public void Save() {
            _context.SaveChanges();
        }

        public void Dispose() {
            return;
        }
    }
}
