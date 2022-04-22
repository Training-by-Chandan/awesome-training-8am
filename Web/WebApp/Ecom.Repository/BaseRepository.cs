using Ecom.Data;
using System;
using System.Data.Entity;
using System.Linq;

namespace Ecom.Repository
{
    public interface IBaseRepository<T>
    {
        (bool, string) Create(T model);

        (bool, string) Edit(T model);

        T FindById(Guid Id);

        IQueryable<T> GetAll();
    }

    public class BaseRepository<T> : IBaseRepository<T>
        where T : class
    {
        private readonly ApplicationDbContext db;
        private DbSet<T> dbset;

        public BaseRepository(
            ApplicationDbContext db
            )
        {
            this.db = db;
            dbset = db.Set<T>();
        }

        public IQueryable<T> GetAll()
        {
            return dbset.AsQueryable<T>();
        }

        public (bool, string) Create(T model)
        {
            try
            {
                dbset.Add(model);
                db.SaveChanges();
                return (true, "Created Successfully");
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }

        public (bool, string) Edit(T model)
        {
            try
            {
                dbset.Attach(model);
                db.Entry(model).State = EntityState.Modified;
                db.SaveChanges();
                return (true, "Editted Successfully");
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }

        public (bool, string) Delete(Guid Id)
        {
            try
            {
                var existing = dbset.Find(Id);
                if (existing == null) return (false, "Not found");

                dbset.Remove(existing);
                db.SaveChanges();
                return (true, "Deleted Successfully");
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }

        public T FindById(Guid Id)
        {
            return dbset.Find(Id);
        }
    }
}