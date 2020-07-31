using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HCWebApp.Models;
using HCWebApp.Repository;
using Microsoft.AspNetCore.Mvc;

namespace HCWebApp.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductRepository _productRepository = null;
        public ProductController()
        {
            _productRepository = new ProductRepository();
        }
        public ViewResult GetAllProducts()
        {
            var data = _productRepository.GetAllProducts();
            return View(data);
        }

        public ProductModel GetProduct(int id)
        {
            return _productRepository.GetProductById(id);
        }

        public List<ProductModel> SearchProducts(string prodName, string prodType)
        {
            return _productRepository.SearchProduct(prodName,prodType);
        }
    }
}