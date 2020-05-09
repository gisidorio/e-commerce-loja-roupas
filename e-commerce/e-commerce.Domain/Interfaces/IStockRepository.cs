using e_commerce.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_commerce.Domain.Interfaces
{
    public interface IStockRepository<T> : IRepositoryBase<Stock>
    {
    }
}
