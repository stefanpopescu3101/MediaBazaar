using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaarApp
{
    class Shelf
    {
        private string shelfCategory;
        private int shelfCapacity;
        private int shelfID;

        public int ID
        {
            get { return shelfID; }
        }
        public string Category
        {
            get { return shelfCategory; }
        }
        public int Capacity
        {
            get { return shelfCapacity; }
        }

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





    }
}
