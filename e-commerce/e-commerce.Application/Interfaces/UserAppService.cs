using e_commerce.Domain.Entities;
using e_commerce.Domain.Interfaces.Services;
using e_commerce.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_commerce.Application.Interfaces
{
    public class UserAppService : IUserAppService
    {
        private IUserService _userService;

        public UserAppService(IUserService userService)
        {
            _userService = userService;
        }

        public User GetLoggedUser(User entity)
        {
            return _userService.GetLoggedUser(entity);
        }
    }
}
