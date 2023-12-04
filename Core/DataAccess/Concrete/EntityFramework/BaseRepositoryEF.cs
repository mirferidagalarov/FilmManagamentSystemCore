using Core.DataAccess.Abstract;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess.Concrete.EntityFramework
{
    public class BaseRepositoryEF<TEntity,TContext> : IBaseRepository<TEntity> 
        where TEntity : BaseEntity, new()
        where TContext:DbContext,new()
    {
        public void Add(TEntity entity)
        { 
            using (TContext context=new TContext())
            {
                var  addedEntity=context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();  
            }
           
        }

        public void Delete(TEntity entity)
        {
            using (TContext context=new TContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public TEntity Get(Expression<Func<TEntity,bool>> predicate)
        {
            using (TContext context=new()) //bu yazilishin adi Target-typed new Expressions
            {

                return context.Set<TEntity>().SingleOrDefault(predicate); 
                
            }
        }

        public IEnumerable<TEntity> GetAll(Expression<Func<TEntity, bool>> predicate=null)
        {
            using (TContext context=new())
            {
                if (predicate is null)
                {
                    return context.Set<TEntity>().ToList();
                }
                return context.Set<TEntity>().Where(predicate).ToList();    
            }
        }

        public void Update(TEntity entity)
        {
            using (TContext context=new TContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State=EntityState.Modified;
                context.SaveChanges();  
            }
        }
    }
}
