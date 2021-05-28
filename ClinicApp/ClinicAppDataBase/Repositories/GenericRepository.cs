using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ClinicAppDataBase.Repositories
{
    public class GenericRepository<TEntity> :IGenericRepository<TEntity> where  TEntity : class
    {
        private readonly DbContext _context;
        private readonly DbSet<TEntity> _dbSet;

        public GenericRepository(DbContext context)
        {
            _context = context;
            _dbSet = context.Set<TEntity>();
        }


        public TEntity GetById(int id)
        {
            return _dbSet.Find(id);
        }

        public IEnumerable<TEntity> GetList()
        {
            return _dbSet.AsNoTracking().ToList();
        }


        public void Add(TEntity item)
        {
            _dbSet.Add(item);
            _context.SaveChanges();
        }

        public void Modify(TEntity item)
        {
            _context.Entry(item).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void Delete(TEntity item)
        {
            _context.Entry(item).State = EntityState.Deleted;
            _dbSet.Remove(item);
            _context.SaveChanges();

        }

        public void DeleteById(int id)
        {
            var obj=_dbSet.Find(id);
            if (obj == null) return;
            _dbSet.Remove(obj);
            _context.SaveChanges();
        }

        public void ModifyById(int id)
        {
            var obj = _dbSet.Find(id);
            if (obj == null) return;
            _context.SaveChanges();
        }

        //сложные методы
        //EFGenericRepository<Phone> phoneRepo = new EFGenericRepository<Phone>(new ApplicationContext());
        //IEnumerable<Phone> phones = phoneRepo.GetWithInclude(p=>p.Company);
        //IEnumerable<Phone> phones = phoneRepo.GetWithInclude(x => x.Company.Name.StartsWith("S"), p => p.Company);

        public IEnumerable<TEntity> GetWithInclude(params Expression<Func<TEntity, object>>[] includeProperties)
        {
            return Include(includeProperties).ToList();
        }

        public IEnumerable<TEntity> GetWithInclude(Func<TEntity, bool> predicate,
            params Expression<Func<TEntity, object>>[] includeProperties)
        {
            var query = Include(includeProperties);
            return query.Where(predicate).ToList();
        }

        private IQueryable<TEntity> Include(params Expression<Func<TEntity, object>>[] includeProperties)
        {
            IQueryable<TEntity> query = _dbSet.AsNoTracking();
            return includeProperties
                .Aggregate(query, (current, includeProperty) => current.Include(includeProperty));
        }
        //сложные методы

    }
}
