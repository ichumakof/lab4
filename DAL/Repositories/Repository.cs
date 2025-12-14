using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DAL.Interfaces;
using System.Linq.Expressions;

namespace DAL.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly Students2Entities _context;

        public Repository(Students2Entities context)
        {
            _context = context;
        }

        public IEnumerable<T> GetAll() => _context.Set<T>().ToList();
        public T GetById(int id) => _context.Set<T>().Find(id);

        public IEnumerable<T> Find(Expression<Func<T, bool>> predicate)
            => _context.Set<T>().Where(predicate).ToList();

        public void Add(T entity) => _context.Set<T>().Add(entity);
        public void Update(T entity)
        {
            // Для EF6 используем присвоение состояния
            _context.Entry(entity).State = System.Data.Entity.EntityState.Modified;
        }
        public void Delete(T entity) => _context.Set<T>().Remove(entity);
        public void Save() => _context.SaveChanges();
    }
}
