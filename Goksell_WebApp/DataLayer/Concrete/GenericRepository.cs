using DataLayer.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataLayer.Concrete
{
    public class GenericRepository<TEntity> : IRepository<TEntity>
        where TEntity : class

    {

        protected readonly DbContext context;
        public GenericRepository(DbContext dbContext)
        {
            context= dbContext;
        }
        public void Create(TEntity entity)
        {

            context.Set<TEntity>().Add(entity);
            
        }

        public void Delete(TEntity entity)
        {

            context.Set<TEntity>().Remove(entity);
            
        }

        public List<TEntity> GetAll()
        {

            return context.Set<TEntity>().ToList();
            
        }

        public TEntity GetById(int id)
        {

            return context.Set<TEntity>().Find(id);
        }

        public virtual void Update(TEntity entity)
        {
           
            context.Entry(entity).State = EntityState.Modified;
            
        }
    }
    
}
