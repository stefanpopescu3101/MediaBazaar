using MediaBazaarApp.Classes.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaarApp
{
   public class Shelf
    {
        private string shelfCategory;
        private int shelfCapacity;
        private int shelfID;

        public int ID
        {
            get;  set;
        }
        public string Category
        {
            get { return shelfCategory; }
        }
        public int Capacity
        {
            get; set;
        }
        public Floors Floors { get; set; }
        public List<Product> products = new List<Product>();

        public Shelf(string shelfCategory, int shelfCapacity)
        {
            this.shelfCategory = shelfCategory;
            this.shelfCapacity = shelfCapacity;
        }

        public Shelf(int shelfID, string shelfCategory, int shelfCapacity)
        {
            this.shelfID = shelfID;
            this.shelfCategory = shelfCategory;
            this.shelfCapacity = shelfCapacity;
        }
        public Shelf(int shelfID, Floors floors)
        {
            this.shelfID = shelfID;
            Floors = floors;
            
        }
        public Shelf( Floors floors)
        {
            
            Floors = floors;

        }
        public Shelf() { }


        public void AddProductToShelf(Product p)
        {
            products.Add(p);
        }

        public List<Product> ReturnProducts()
        {
            return products; 
        }

        public Product[] ReturnProducts2()
        {
            return products.ToArray();
        }


    }
}
