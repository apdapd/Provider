using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Provider.Data.EntityFramework.Repository
{
    public interface IRepository<T>
       where T : class
    {
        IQueryable<T> GetAll(); // получение всех объектов
        T Get(int id); // получение одного объекта по id
        void Create(T item); // создание объекта
        void Update(T item); // обновление объекта
        void Delete(int id); // удаление объекта по id
        void Save();  // сохранение изменений
    }

    public class GenericRepository<T> : IRepository<T> where T : class
    {
        protected readonly DbContext db;

        protected DbSet<T> DbSet;

        public GenericRepository(DbContext dbContext)
        {
            db = dbContext;
            DbSet = db.Set<T>();
        }

        public IQueryable<T> GetAll()
        {
            return DbSet;
        }
        public T Get(int id)
        {
            return DbSet.Find(id);
        }

        public void Create(T item)
        {
            DbSet.Add(item);
        }

        public void Update(T item)
        {
            db.Entry(item).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            T item = DbSet.Find(id);
            if (item != null)
                DbSet.Remove(item);
        }

        public void Save()
        {
            db.SaveChanges();
        }
    }

    public class TarifRepository : GenericRepository<Tarif>
    {
        public TarifRepository()
            : base(new WorkContext())
        {
        }
       
    }
    public class AbonentRepository : GenericRepository<Abonent>
    {
        public AbonentRepository()
            : base(new WorkContext())
        {

        }
    }

}
