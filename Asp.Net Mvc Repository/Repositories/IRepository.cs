using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asp.Net_Mvc_Repository.Repositories
{
    interface IRepository<T> where T : class
    {
        void Add(T newEntity);
        IEnumerable<T> SelectAll();
        T SelectById(object id);
        void Update(T exEntity);
        void Delete(object id);
        void Save();
    }
}
