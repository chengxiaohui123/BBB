using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    interface Interface1<T> where T : class
    {
            IEnumerable<T> GetAll(int PageIndex,int PageSize,out int Total);
            T Get(Func<T, bool> predicate);
            void Add(T entity);
            void Update(T entity);
            void Delete(T entity);
    }
}
