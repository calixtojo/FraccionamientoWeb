using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Threading.Tasks;
using FraccionamientoWeb.BL.Data;

namespace FraccionamientoWeb.BL.Repositories.Implements
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        private readonly FraccionamientoContext fraccionamientoContext;

        public GenericRepository(FraccionamientoContext fraccionamientoContext)
        {
            this.fraccionamientoContext = fraccionamientoContext;
        }

        public async Task Delete(int id)
        {
            var entity = await GetById(id);

            if (entity == null)
                throw new Exception("The entity is null");

            fraccionamientoContext.Set<TEntity>().Remove(entity);
            await fraccionamientoContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<TEntity>> GetAll()
        {
            return await fraccionamientoContext.Set<TEntity>().ToListAsync();
        }

        public async Task<TEntity> GetById(int id)
        {
            return await fraccionamientoContext.Set<TEntity>().FindAsync(id);
        }

        public async Task<TEntity> Insert(TEntity entity)
        {
            fraccionamientoContext.Set<TEntity>().Add(entity);
            await fraccionamientoContext.SaveChangesAsync();
            return entity;
        }

        public async Task<TEntity> Update(TEntity entity)
        {
            //fraccionamientoContext.Entry(entity).State = EntityState.Modified;
            fraccionamientoContext.Set<TEntity>().AddOrUpdate(entity);
            await fraccionamientoContext.SaveChangesAsync();
            return entity;
        }
    }
}
