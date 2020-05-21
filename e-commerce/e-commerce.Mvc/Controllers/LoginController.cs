using e_commerce.Application.Interfaces;
using e_commerce.Domain.Entities;
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
            User user = new User
            {
                Username = username,
                Password = password
            };

            User LoggedUser = _userAppService.GetLoggedUser(user);

            if (LoggedUser != null)
            {
                Session["LoggedUser"] = LoggedUser;
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return RedirectToAction("Index");
            }
        }
    }
}