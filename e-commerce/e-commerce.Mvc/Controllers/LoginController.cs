using e_commerce.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace e_commerce.Mvc.Controllers
{
    public class LoginController : Controller
    {
        private readonly IUserAppService _userAppService;

        public LoginController(IUserAppService userAppService)
        {
            _userAppService = userAppService;
        }

        // GET: Login
        public ActionResult Index()
        {
            //_userAppService.GetLoggedUser(null);
            return View();
        }

        public ActionResult Authenticate(string username, string password)
        {

            return View();
        }
    }
}