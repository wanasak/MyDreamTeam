using MyDreamTeam.Data.Infrastructure;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MyDreamTeam.Data.Repositories
{
    public class RepositoryBase<T> where T : class
    {
        private MyDreamTeamContext dbContext;
        private readonly IDbSet<T> dbSet;

        protected IDbFactory DbFactory
        {
            get;
            private set;
        }

        protected MyDreamTeamContext DbContext
        {
            get
            {
                return dbContext ?? (dbContext = DbFactory.Init());
            }
        }

        public RepositoryBase(IDbFactory dbFactory)
        {
            DbFactory = dbFactory;
            dbSet = DbContext.Set<T>();
        }

        #region Implementations

        public virtual void Add(T entity)
        {
            dbSet.Add(entity);
        }

        public virtual void Update(T entity)
        {
            dbSet.Attach(entity);
            dbContext.Entry(entity).State = EntityState.Modified;
        }

        public virtual void Delete(T entity)
        {
            dbSet.Remove(entity);
        }

        public virtual void Delete(Expression<Func<T, bool>> predict)
        {
            IEnumerable<T> objects = dbSet.Where<T>(predict).AsEnumerable();
            foreach (var obj in objects)
                dbSet.Remove(obj);
        }

        public virtual T GetById(int id)
        {
            return dbSet.Find(id);
        }

        public virtual IEnumerable<T> GetAll()
        {
            return dbSet.ToList();
        }

        public virtual IEnumerable<T> GetMany(Expression<Func<T, bool>> predict)
        {
            return dbSet.Where(predict).ToList();
        }

        public virtual T Get(Expression<Func<T, bool>> predict)
        {
            return dbSet.Where(predict).FirstOrDefault<T>();
        }

        #endregion
    }
}
