using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediaBazaarApp.Classes.Enums;

namespace MediaBazaarApp
{
   public class Product
    {
        public int ID { get; set; }
        public string Name { get; private set; }
        public string Brand { get; private set; }
        public decimal CostPrice { get; private set; }
        public decimal SellPrice { get; private set; }
        public int InStock { get; private set; }
        public int MaxCapacity { get; private set; }
        public int Threshold { get; private set; }
        public int Sold { get; private set; }
        public decimal Measurements { get; private set; }
       
        public string BoxSize { get; private set; }
        public int ShelfId { get;  set; }
        public int ShelfFloor { get; set; }

        public Product (string name, string brand ,decimal costPrice, decimal sellPrice, int inStock, int maxCapacity, int threshold, int sold, decimal measurements, string boxSize)
        {
            this.Name = name;
            this.Brand = brand;
            this.CostPrice = costPrice;
            this.SellPrice = sellPrice;
            this.InStock = inStock;
            this.MaxCapacity = maxCapacity;
            this.Threshold = threshold;
            this.Sold = sold;
            this.Measurements = measurements;
            this.BoxSize = boxSize;
        }

        public Product(Shelf shelf , Floors floors)
        {
            this.ShelfId = shelf.ID;
           // this.ShelfFloor = ;
        }
        public Product(int shelfId, int shelfFloor)
        {
            this.ShelfId = shelfId;
            this.ShelfFloor = shelfFloor;
        }

        public void EditProduct(string name, string brand,decimal costPrice, decimal sellPrice,int maxCapacity, int threshold,decimal measurements,string boxSize)
        {
            this.Name = name;
            this.Brand = brand;
            this.CostPrice = costPrice;
            this.SellPrice = sellPrice;
            this.MaxCapacity = maxCapacity;
            this.Threshold = threshold;
            this.Measurements = measurements;
            this.BoxSize = boxSize;
        }

        public override string ToString()
        {
            return $"ID: {this.ID}; Name: {this.Name}";
        }
        public void RestockProduct(int quantity)
        {
            this.InStock += quantity;
        }
    }
}
