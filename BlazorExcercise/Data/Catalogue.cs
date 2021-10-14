using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BlazorExcercise.Data
{
    public class Catalogue
    {
        public delegate void ChangeHandler();
        public event ChangeHandler CatalogueChanged;
        private List<Product> products = new List<Product>();
        public IEnumerable<Product> AllProducts()
        {
            return products;
        }
        public void AddProduct(Product p)
        {
            products.Add(p);
            CatalogueChanged.Invoke();
        }
        public void RemoveProduct(Product p)
        {
            products.Remove(p);
            CatalogueChanged.Invoke();
        }
        public void UpdateProduct(Product p)
        {
            CatalogueChanged.Invoke();
        }
    }
}
