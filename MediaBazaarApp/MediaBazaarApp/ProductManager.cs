using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaarApp
{
    public class ProductManager
    {
        public List<Product> Products { get; private set; }
        public ProductManager()
        {
            this.Products = new List<Product>();
        }

        public bool AddProduct(Product product)
        {
            if (product != null)
            {
                this.Products.Add(product);
                return true;
            }
            else { return false; }
        }


    }
}
