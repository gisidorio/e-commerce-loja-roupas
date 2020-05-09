using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_commerce.Domain.Interfaces
{
    public interface IRepositoryBase<T> where T : class
    {
        void Save(string procedure, object parameters = null);
        List<T> GetAll(string procedure, object parameters = null);
        T Get(string procedure, object parameters = null);
        void Update(string procedure, object parameters = null);
        void Delete(string procedure, object parameters = null);
    }
}
