using System;
using System.Collections.Generic;
using System.Text;
using PETDataBase.Domain.Models;
using PETDataBase.EntityFramework;

namespace PETDataBase.Repository
{
    public class Repository
    {
        private PETDBContext dataContext;

        public Repository()
        {
            dataContext = new PETDBContext();
        }

        #region Methods
        public void Add<T>(T entity) where T : DomainObject
        {
            dataContext.Set<T>().Add(entity);
            dataContext.SaveChanges();
        }
        public void Delete<T>(T entity) where T : DomainObject
        {
            dataContext.Set<T>().Remove(entity);
            dataContext.SaveChanges();
        }
        public void Edit<T>(T entity) where T : DomainObject
        {
            dataContext.Set<T>().Update(entity);
            dataContext.SaveChanges();
        }
        public IEnumerable<T> GetAll<T>() where T : DomainObject
        {
            IEnumerable<T> result = dataContext.Set<T>();
            return result;
        }
        #endregion
    }
}
