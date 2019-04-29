using AHAS.PO.INFRA.DATA.Context;
using AHAS.PO.LOGIC.DOMAIN.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace AHAS.PO.INFRA.DATA.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected DataBaseContext Db;
        protected DbSet<TEntity> DbSet;

        public Repository(DataBaseContext context)
        {
            Db = context;
            DbSet = Db.Set<TEntity>();
        }

        public TEntity Inserir(TEntity obj)
        {
            return DbSet.Add(obj);
        }

        public TEntity Alterar(TEntity obj)
        {
            var entry = Db.Entry(obj);
            DbSet.Attach(obj);
            entry.State = EntityState.Modified;

            return obj;
        }

        public bool Excluir(Guid id)
        {
            DbSet.Remove(DbSet.Find(id));

            return true;
        }

        public TEntity Consultar(Guid id)
        {
            return DbSet.Find(id);
        }

        public IEnumerable<TEntity> Consultar(Expression<Func<TEntity, bool>> query)
        {
            return DbSet.Where(query);
        }

        public IEnumerable<TEntity> Listar()
        {
            return DbSet.ToList();
        }

        public IEnumerable<TEntity> Listar(int t, int s)
        {
            return DbSet.Take(t).Skip(s).ToList();
        }

        public IEnumerable<TEntity> Listar(Expression<Func<TEntity, bool>> fil, params Expression<Func<TEntity, object>>[] ord)
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
            return Db.SaveChanges();
        }

        public void Dispose()
        {
            Db.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
