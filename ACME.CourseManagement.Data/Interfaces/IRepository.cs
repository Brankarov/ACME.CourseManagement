using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACME.CourseManagement.Data.Interfaces
{
    public interface IRepository<T>
    {
        IEnumerable<T> GetEnumerables();

        void Add(T item);
    }
}
