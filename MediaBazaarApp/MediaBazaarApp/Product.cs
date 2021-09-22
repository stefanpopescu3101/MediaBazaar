using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaarApp
{
   public class Product
    {
        private int ID { get; set; }
        private string Name { get; set; }
        private decimal CostPrice { get; set; }
        private decimal SellPrice { get; set; }
        private int InStock { get; set; }
        private int MaxCapacity { get; set; }
        private int Threshold { get; set; }
        private int Sold { get; set; }
        private decimal Size { get; set; }

        public Product (string name, decimal costPrice, decimal sellPrice, int inStock, int maxCapacity, int threshold, int sold, decimal size)
        {
            this.Name = name;
            this.CostPrice = costPrice;
            this.SellPrice = sellPrice;
            this.InStock = inStock;
            this.MaxCapacity = maxCapacity;
            this.Threshold = threshold;
            this.Sold = sold;
            this.Size = size;
        }

        public void EditProduct(string name, decimal costPrice, decimal sellPrice, int threshold, decimal size)
        {
            this.Name = name;
            this.CostPrice = costPrice;
            this.SellPrice = sellPrice;
            this.Threshold = threshold;
            this.Size = size;
        }

        public override string ToString()
        {
            return $"ID: {this.ID}; Name: {this.Name}";
        }
    }
}
