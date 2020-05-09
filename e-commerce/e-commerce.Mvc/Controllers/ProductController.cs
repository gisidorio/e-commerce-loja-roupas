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
            var productsViewModel = new List<ProductViewModel>();
            List<Product> products = new List<Product>();

            products = _productRepository.GetAll();

            #region TRANSFORMA DA ENTITY PARA VIEW MODEL
            for (int i = 0; i < products.Count; i++)
            {
                var pViewModel = new ProductViewModel
                {
                    Id = products[i].Id,
                    ProductName = products[i].ProductName,
                    Description = products[i].Description,
                    Activated = products[i].Activated
                };

                productsViewModel.Add(pViewModel);
            }
            #endregion


            return View(productsViewModel);
        }
    }
}