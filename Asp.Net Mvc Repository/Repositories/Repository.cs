using Asp.Net_Mvc_Repository.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Asp.Net_Mvc_Repository.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        CompanyContext context = new CompanyContext();
        protected DbSet<T> dbSet { get; set; }
        public Repository()
        {
            context = new CompanyContext();
            dbSet = context.Set<T>();
        }
        public Repository(CompanyContext comp)
        {
            context = comp;
            dbSet = context.Set<T>();
        }
        public void Delete(object id)
        {
            T exEntity = dbSet.Find(id);
            dbSet.Remove(exEntity);
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public IEnumerable<T> SelectAll()
        {
            return dbSet.ToList();
        }

        public T SelectById(object id)
        {
            return dbSet.Find(id);
        }

        public void Update(T exEntity)
        {
            dbSet.Attach(exEntity);
            context.Entry(exEntity).State = EntityState.Modified;
        }

        public void Add(T newEntity)
        {
            dbSet.Add(newEntity);
        }
    }
}