using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    interface Interface1<T> where T : class
    {
            IEnumerable<T> GetAll(int PageIndex,int PageSize,out int Total,mmm a);
            
            T Get(int Id);
            void Add(T entity);
            void Update(T entity);
            void Delete(int Id);
             void BatchDelete(string str);
    }
}
