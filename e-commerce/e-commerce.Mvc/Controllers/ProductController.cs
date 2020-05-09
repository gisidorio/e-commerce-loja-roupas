using e_commerce.Domain.Entities;
using e_commerce.Infra.Data.Repositories;
using e_commerce.Mvc.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace e_commerce.Mvc.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductRepository _productRepository;

        public ProductController()
        {
            _productRepository = new ProductRepository();
        }

        // GET: Product
        public ActionResult Index()
        {
            ProductViewModel pr = new ProductViewModel();
            List<Product> products = new List<Product>();

            products = _productRepository.GetAll();


            return View();
        }
    }
}