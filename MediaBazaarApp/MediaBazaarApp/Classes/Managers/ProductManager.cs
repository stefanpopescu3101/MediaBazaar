using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediaBazaarApp.Classes.Enums;

namespace MediaBazaarApp
{
    public class ProductManager
    {
        public List<Product> Products { get; private set; }
        private ProductMediator productMediator;
        Shelf s;
        public ProductManager()
        {
            s = new Shelf();
            this.Products = new List<Product>();
            this.productMediator = new ProductMediator();
        }

        public bool Add(Product product)
        {
            Load();
            if(Products.Count != 0)
            {
                foreach(Product p in Products)
                {
                    if(p.Name == product.Name)
                    {

                        return false;
                        
                    }
                }
                this.Products.Add(product);
                this.productMediator.Add(product);
                return true;
            }
            else
            {
                this.Products.Add(product);
                this.productMediator.Add(product);
                return true;
            }
          
        }
        public bool Remove(Product product)
        {
            if (this.Get(product.ID) != null)
            {
                this.Products.Remove(product);
                this.productMediator.Remove(product);
                return true;
            }
            else { return false; }

        }

    
        
        public bool Update(Product product)
        {
            if (this.Products.Contains(product))
            {
                this.productMediator.Update(product);
                return true;
            }
            else { return false; }
        }
        public Product Get(int id)
        {
            foreach (Product product in this.GetProducts())
            {
                if (product.ID == id)
                {
                    return product;
                }
            }
            return null;
        }
        public Product GetShelfFields()
        {
            //shelfId = s.ID;
            //floorId = s.Floors;
            //foreach (Product product in this.GetProducts())
            //{
            //    if (product.ShelfId == shelfId && s.ShelfFloor == floorId)
            //    {
            //        return product;
            //    }
            //}
            //return null;
            return null;
        }


    //public bool AddProductToShelf(Product p)
    //{

    //    if (this.GetShelfFields() != null)
    //    {
    //        //this.Products.Add(p);
    //        this.productMediator.AddProductToShelf(p);
    //        return true;
    //    }
    //    else { return false; }

    //}

        //public List<Product> GetAll()
        //{
        //    this.Load();

        //    if (this.Products != null)
        //    {
        //        return this.Products;
        //    }
        //    else { return null; }
        //}
        public bool Load()
        {
            this.Products = this.productMediator.GetAll();

            if (this.Products != null)
            {
                return true;
            }
            else { return false; }
        }

        public Product[] GetProducts()
        {
            return Products.ToArray();
        }
        public List<Product> GetListProd()
        {
            return productMediator.GetAll();
        }

        public void AddRemoveStock(int amount, int id, bool remove)
        {
            if(remove)
            {
                this.productMediator.RemoveStock(amount, id);
            }
            else
            {
                this.productMediator.AddStock(amount,id);
            }
        }

        //public void RemoveFRomShelfAndAddToStorage(int amount, int id, bool remove)
        //{
        //    if (remove)
        //    {
        //        this.productMediator.AddProductBACKToStock(amount, id);
        //    }
        //    else
        //    {
        //        this.productMediator.RemoveFromShelf(amount, id);
        //    }
        //}

        public List<Product> GetAll()
        {
            this.Load();
            if(this.Products != null)
            {
                return this.Products;
            }
            else { return null; }
        }
        public List<Product>GetProductBySpesificShelf(Shelf s)
        {
            List<Product> products = new List<Product>();
            foreach(Product p in this.GetAll())
            {
                if (p.ShelfFloor == s.ID)
                {
                    products.Add(p);
                }
            }return products;
        }


    }
}
