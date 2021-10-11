using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaarApp
{
    class ShelfManager
    {
        List<Shelf> shelves;
        ShelfMediator shelfMediator;

        public ShelfManager()
        {
            shelves = new List<Shelf>();
            shelfMediator = new ShelfMediator();
        }


        public void AddShelf(Shelf shelf)
        {
            shelves.Add(shelf);
            shelfMediator.AddShelf(shelf);
        }

        public void RemoveShelf(int id)
        {
            shelfMediator.RemoveShelf(id);
        }


        public void EditShelf(int id)
        {

        }

        public List<Shelf> GetShelves()
        {
            return shelfMediator.GetShelves();
        }


    }
}
