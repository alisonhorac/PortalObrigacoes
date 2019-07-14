using AHAS.PO.INFRA.DATA.Context;
using AHAS.PO.LOGIC.DOMAIN.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace AHAS.PO.INFRA.DATA.Repository
{
    public class Repository<TEntity> : IDisposable, IRepository<TEntity> where TEntity : class
    {
        protected DataBaseContext DataBase;
        protected DbSet<TEntity> DbSet;

        public Repository(DataBaseContext context)
        {
            DataBase = context;
            DbSet = DataBase.Set<TEntity>();
        }

        public virtual TEntity Inserir(TEntity obj)
        {
            try
            {
                return DbSet.Add(obj);

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public virtual TEntity Alterar(TEntity obj)
        {
            var entry = DataBase.Entry(obj);
            DbSet.Attach(obj);
            entry.State = EntityState.Modified;

            return obj;
        }

        public virtual bool Excluir(Guid id)
        {
            DbSet.Remove(DbSet.Find(id));

            return true;
        }

        public virtual bool Excluir(int id)
        {
            DbSet.Remove(DbSet.Find(id));

            return true;
        }

        public virtual TEntity Consultar(int id)
        {
            return DbSet.Find(id);
        }

        public virtual TEntity Consultar(Guid id)
        {
            return DbSet.Find(id);
        }

        public virtual IEnumerable<TEntity> Consultar(Expression<Func<TEntity, bool>> query)
        {
            return DbSet.Where(query);
        }

        public virtual IEnumerable<TEntity> Listar()
        {
            return DbSet.ToList();
        }

        public virtual IEnumerable<TEntity> Listar(int t, int s)
        {
            return DbSet.Take(t).Skip(s).ToList();
        }

        public virtual IEnumerable<TEntity> Listar(Expression<Func<TEntity, bool>> fil, params Expression<Func<TEntity, object>>[] ord)
        {
            var obj = DbSet.Where(fil).OrderBy(ord.First());

            if (ord.Length > 1)
            {
                for (int i = 1; i < ord.Length; i++)
                {
                    obj = obj.ThenBy(ord[i]);
                }
            }
            return obj.ToList();
        }

        public int SaveChanges()
        {
            return DataBase.SaveChanges();
        }

        public void Dispose()
        {
            DataBase.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
