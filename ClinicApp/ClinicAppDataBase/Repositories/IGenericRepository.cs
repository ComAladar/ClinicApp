using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicAppDataBase.Repositories
{
    /// <summary>
    /// Интерфейс для стандратного репозитория базы данных EF.
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public interface IGenericRepository<TEntity> where  TEntity : class
    {
        TEntity GetById(int id);
        IEnumerable<TEntity> GetList();
        void Add(TEntity item);
        void Modify(TEntity item);
        void Delete(TEntity item);
    }
}
