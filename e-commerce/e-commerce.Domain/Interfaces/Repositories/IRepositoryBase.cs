using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_commerce.Domain.Interfaces
{
    public interface IRepositoryBase<T> where T : class
    {
        void ExecuteSave(string procedure, object parameters = null);
        List<T> QueryList(string procedure, object parameters = null);
        T Query(string procedure, object parameters = null);
        void ExecuteUpdate(string procedure, object parameters = null);
        void ExecuteDelete(string procedure, object parameters = null);
    }
}
