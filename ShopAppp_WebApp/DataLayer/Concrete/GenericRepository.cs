using DataLayer.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public async Task CreateAsync(TEntity entity)
        {
            await context.Set<TEntity>().AddAsync(entity);
        }

        public void Delete(TEntity entity)
        {

            context.Set<TEntity>().Remove(entity);
            
        }

        public async Task<List<TEntity>> GetAll()
        {

            return await context.Set<TEntity>().ToListAsync();
            
        }

        public async Task<TEntity> GetById(int id)
        {

            return await context.Set<TEntity>().FindAsync(id);
        }

        public virtual void Update(TEntity entity)
        {
           
            context.Entry(entity).State = EntityState.Modified;
            
        }
    }
    
}
