using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using ProjetoModeloDDD.Domain.Interfaces;
using ProjetoModeloDDD.Infra.Data.Context;

namespace ProjetoModeloDDD.Infra.Data.Repositories
{
    public class RepositoryBase<TEntity> : IDisposable, IRepositoryBase<TEntity> where TEntity : class
    {
        protected readonly ProjetoModelo DbContext = new ProjetoModelo();

        public void Add(TEntity obj)
        {
            DbContext.Set<TEntity>().Add(obj);

            DbContext.SaveChanges();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return DbContext.Set<TEntity>().ToList();
        }

        public TEntity GetById(int id)
        {
            return DbContext.Set<TEntity>().Find(id);
        }

        public void Remove(TEntity obj)
        {
            DbContext.Set<TEntity>().Remove(obj);
            DbContext.SaveChanges();
        }

        public void Update(TEntity obj)
        {
            DbContext.Entry(obj).State = EntityState.Modified;
            DbContext.SaveChanges();
        }
        public void Dispose()
        {
            throw new NotImplementedException();
        }

    }
}
