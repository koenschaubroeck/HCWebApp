using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HCWebApp.Controllers
{
    public class ProductController : Controller
    {
        public string GetAllProducts()
        {
            return "All Products";
        }

        public string GetProduct(int id)
        {
            return $"Product with id = {id}";
        }

        public string SearchProducts(string prodName, string prodType)
        {
            return $"Product with Name = {prodName} & Type = {prodType}";
        }
    }
}