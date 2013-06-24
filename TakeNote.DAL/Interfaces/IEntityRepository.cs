using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;
namespace TakeNote.DAL
{
    /// <summary>
    /// Implements the Repository Pattern and also the Unit of Work pattern. In the next phase I may separate the Unit of Pattern implementation.
    /// </summary>
    /// <typeparam name="T"></typeparam>
     public interface IEntityRepository<T> where T: class
    {
         T Find(int id);
         List<T> FindMany(Expression<Func<T, bool>> where);
         List<T> GetAll();
         T FindOne(Expression<Func<T, bool>> where);
         /// <summary>
         /// Entity will be added when <see cref="SaveChanges"/> SaveChanges is called.
         /// </summary>
         /// <param name="entity"></param>
         void Add(T entity);
         /// <summary>
         /// Entity will updated when SaveChanges is called.
         /// </summary>
         /// <param name="entity"></param>
         void Update(T entity);
         /// <summary>
         /// Entity will be deleted from the database when SaveChanges is called.
         /// </summary>
         /// <param name="entityt"></param>
         void Delete(T entityt);
         void SaveChanges();
    }
}
