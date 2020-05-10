using e_commerce.Domain.Entities;
using e_commerce.Domain.Interfaces;
using e_commerce.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_commerce.Domain.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public User GetLoggedUser(User entity)
        {
           return _userRepository.GetLoggedUser(entity);
        }
    }
}
