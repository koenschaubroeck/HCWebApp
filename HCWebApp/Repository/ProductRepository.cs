using HCWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HCWebApp.Repository
{
    public class ProductRepository
    {
        public List<ProductModel> GetAllProducts()
        {
            return DataSource();
        }
        
        public ProductModel GetProductById(int id)
        {
            return DataSource().Where(x => x.Id == id).FirstOrDefault();
        }

        public List<ProductModel> SearchProduct(string prodName, string prodType)
        {
            return DataSource().Where(x => x.Name.Contains(prodName) || x.Type.Contains(prodType)).ToList();
        }

        private List<ProductModel> DataSource()
        {
            return new List<ProductModel>()
            {
                new ProductModel(){Id= 1, Name="Crunch", Type="Ontbijt Shake"},
                new ProductModel(){Id= 2, Name="Vanille", Type="Ontbijt Shake"},
                new ProductModel(){Id= 3, Name="Appel", Type="Ontbijt Shake"},
                new ProductModel(){Id= 4, Name="Aardbei", Type="Ontbijt Shake"},
                new ProductModel(){Id= 5, Name="Chocolade", Type="Ontbijt Shake"},
            };
        }
    }
}
