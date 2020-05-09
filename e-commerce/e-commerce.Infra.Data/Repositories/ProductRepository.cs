using e_commerce.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_commerce.Infra.Data.Repositories
{
    public class ProductRepository : RepositoryBase<Product>
    {
        public void Save(Product product)
        {
            try
            {
                base.Save(Procedures.SPI_PRODUCT, product);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                base.Dispose();
            }
        }

        public List<Product> GetAll() 
        {
            List<Product> products = null;

            try
            {
                products = base.GetAll(Procedures.SPS_PRODUCT);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                base.Dispose();
            }

            return products;
        }
    }
}
