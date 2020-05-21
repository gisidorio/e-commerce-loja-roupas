using e_commerce.Domain.Entities;
using e_commerce.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_commerce.Infra.Data.Repositories
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public User GetLoggedUser(User entity)
        {
            User user = null;

            try
            {
                user = base.Query("", entity);
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                base.Dispose();
            }

            return user;
        }

        public void Save(User entity)
        {
            try
            {
                base.ExecuteSave(Procedures.SPI_PRODUCT, entity);
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
    }
}
