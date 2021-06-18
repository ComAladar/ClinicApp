using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ClinicAppDataBase.Repositories
{
    /// <summary>
    /// Класс для работы с контекстм базы данных на основе интерфейса IGenericRepository.
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public class GenericRepository<TEntity> :IGenericRepository<TEntity> where  TEntity : class
    {
        /// <summary>
        /// Поле для хранения контекста базы данных.
        /// </summary>
        private readonly DbContext _context;
        /// <summary>
        /// Поле для хранения всех экземпляров из контекста.
        /// </summary>
        private readonly DbSet<TEntity> _dbSet;

        /// <summary>
        /// Конструктор репозитория.
        /// </summary>
        /// <param name="context"></param>
        public GenericRepository(DbContext context)
        {
            _context = context;
            _dbSet = context.Set<TEntity>();
        }

        /// <summary>
        /// Метод для поиска записи в БД по ИД.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public TEntity GetById(int id)
        {
            return _dbSet.Find(id);
        }

        /// <summary>
        /// Метод для нахождения списка определенного типа элементов в БД.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<TEntity> GetList()
        {
            return _dbSet.AsNoTracking().ToList();
        }

        /// <summary>
        /// Метод для добавления новой запаси в БД.
        /// </summary>
        /// <param name="item"></param>
        public void Add(TEntity item)
        {
            _dbSet.Add(item);
            _context.SaveChanges();
        }

        /// <summary>
        /// Метод для фиксирования изменений в записи в БД.
        /// </summary>
        /// <param name="item"></param>
        public void Modify(TEntity item)
        {
            _context.Entry(item).State = EntityState.Modified;
            _context.SaveChanges();
        }

        /// <summary>
        /// Метод для удаления записи в БД.
        /// </summary>
        /// <param name="item"></param>
        public void Delete(TEntity item)
        {
            _context.Entry(item).State = EntityState.Deleted;
            _dbSet.Remove(item);
            _context.SaveChanges();

        }

        /// <summary>
        /// Метод для удаления записи по ИД в БД.
        /// </summary>
        /// <param name="id"></param>
        public void DeleteById(int id)
        {
            var obj=_dbSet.Find(id);
            if (obj == null) return;
            _dbSet.Remove(obj);
            _context.SaveChanges();
        }

        /// <summary>
        /// Метод для изменения записи по ИД в БД.
        /// </summary>
        /// <param name="id"></param>
        public void ModifyById(int id)
        {
            var obj = _dbSet.Find(id);
            if (obj == null) return;
            _context.SaveChanges();
        }

        //Примеры использованя методов ниже:
        //EFGenericRepository<Phone> phoneRepo = new EFGenericRepository<Phone>(new ApplicationContext());
        //IEnumerable<Phone> phones = phoneRepo.GetWithInclude(p=>p.Company);
        //IEnumerable<Phone> phones = phoneRepo.GetWithInclude(x => x.Company.Name.StartsWith("S"), p => p.Company);

        /// <summary>
        /// Метод для поиска списка определенных записей с расширенным запросов в БД.
        /// </summary>
        /// <param name="includeProperties"></param>
        /// <returns></returns>
        public IEnumerable<TEntity> GetWithInclude(params Expression<Func<TEntity, object>>[] includeProperties)
        {
            return Include(includeProperties).ToList();
        }

        /// <summary>
        /// Методя для поиска списка определенных записей с помощью SQL-запроса в БД.
        /// </summary>
        /// <param name="predicate"></param>
        /// <param name="includeProperties"></param>
        /// <returns></returns>
        public IEnumerable<TEntity> GetWithInclude(Func<TEntity, bool> predicate,
            params Expression<Func<TEntity, object>>[] includeProperties)
        {
            var query = Include(includeProperties);
            return query.Where(predicate).ToList();
        }

        /// <summary>
        /// Метод для составления запросов к БД.
        /// </summary>
        /// <param name="includeProperties"></param>
        /// <returns></returns>
        private IQueryable<TEntity> Include(params Expression<Func<TEntity, object>>[] includeProperties)
        {
            IQueryable<TEntity> query = _dbSet.AsNoTracking();
            return includeProperties
                .Aggregate(query, (current, includeProperty) => current.Include(includeProperty));
        }
    }
}
