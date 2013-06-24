using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;
using TakeNote.Model;
using System.Data.Entity;
namespace TakeNote.DAL
{
    public abstract class BaseRepository<T> where T: class
    {
        private TakeNoteContext dbContext;
        private IDbSet<T> entitiesSet;
        protected BaseRepository(TakeNoteContext context)
        {
            if (context == null)
            {
                throw new ArgumentNullException("context");
            }
            this.dbContext = context;
            this.entitiesSet = dbContext.Set<T>();
        }
        public virtual T Find(int id)
        {
            return entitiesSet.Find(id);
        }
        public virtual List<T> GetAll()
        {
            return this.FindMany((e) => true);
        }
        public virtual List<T> FindMany(Expression<Func<T, bool>> whereFunction)
        {
            return entitiesSet.Where(whereFunction).ToList();
        }
        public virtual T FindOne(Expression<Func<T, bool>> whereFunction)
        {
            return entitiesSet.Where(whereFunction).FirstOrDefault();

        }
        public virtual void Add(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entitiesSet.Add(entity);
      }
        public virtual void Update(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entitiesSet.Attach(entity);
            dbContext.Entry(entity).State = System.Data.EntityState.Modified;
            
        }
        public virtual void Delete(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entitiesSet.Remove(entity);
        }
        public virtual void SaveChanges()
        {
            if (dbContext == null)
            {
                throw new Exception("The db context is null.");
            }
            this.dbContext.SaveChanges();
        }
    }
}
