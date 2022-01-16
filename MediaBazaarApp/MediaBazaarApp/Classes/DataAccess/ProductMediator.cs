using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace MediaBazaarApp
{
    public class ProductMediator : DataAccess
    {
        public bool Add(Product product)
        {
            if (ConnOpen())
            {
                query = "INSERT INTO products(name,brand,cost_price,selling_price,in_stock,max_capacity,threshold,sold)" +
                    "VALUE (@name,@brand, @costPrice,@sellingPrice,@inStock,@maxCapacity,@threshold,@sold)";
                SqlQuery(query);

                AddWithValue("@name", product.Name);
                AddWithValue("@brand", product.Brand);
                //TO DO: AddWithValue("@category", product.);
                AddWithValue("@costPrice", product.CostPrice);
                AddWithValue("@sellingPrice", product.SellPrice);
                AddWithValue("@inStock", product.InStock);
                AddWithValue("@maxCapacity", product.MaxCapacity);
                AddWithValue("@threshold", product.Threshold);
                AddWithValue("@sold", product.Sold);
             //   AddWithValue("@measurements", product.Measurements);
               // AddWithValue("@box_size", product.BoxSize);

                NonQueryEx();

                product.ID = Convert.ToInt32(command.LastInsertedId);

                Close();
                return true;
            }
            else
            {
                Close();
                return false;
            }
        }
        //public bool AddProductToShelf(Product product)
        //{

        //    if (ConnOpen())
        //    {

        //        query = "UPDATE products SET shelf = @shelf, floor = @floor WHERE id = @id";
        //        SqlQuery(query);
        //        AddWithValue("@shelf", product.ShelfId);
        //        AddWithValue("@floor", product.ShelfFloor);
        //        AddWithValue("@id", product.ID);
        //        NonQueryEx();


        //        Close();
        //        return true;
        //    }
        //    else
        //    {
        //        Close();
        //        return false;
        //    }

        //}

      
    //This is for removing products from the main storage so it can be added to shelfes 
        public void RemoveStock(int moved , int id)
        {
            if (ConnOpen())
            {
                query = "UPDATE `products` SET `in_stock` = `in_stock`-@amount WHERE `id` = @id;";
                SqlQuery(query);
                AddWithValue("amount", moved);
                AddWithValue("id", id);
                NonQueryEx();

                Close();

            }
            else
            {
                Close();
            }
        }
        ////This method is for returng a product from shelf back to storage
        //public void AddProductBACKToStock(int moved, int id)
        //{
        //    if (ConnOpen())
        //    {
        //        query = "UPDATE `products` SET `in_stock` = `in_stock`-@amount WHERE `id` = @id;";
        //        SqlQuery(query);
        //        AddWithValue("amount", moved);
        //        AddWithValue("id", id);
        //        NonQueryEx();

        //        Close();

        //    }
        //    else
        //    {
        //        Close();
        //    }
        //}
        //This is for adding product to a shelf
        public void AddStock(int moved, int id)
        {
            if (ConnOpen())
            {
                query = "UPDATE `products` SET `in_stock` = `in_stock`+@amount WHERE `id` = @id;";
                SqlQuery(query);
                AddWithValue("amount", -moved);
                AddWithValue("id", id);
                NonQueryEx();

                Close();

            }
            else
            {
                Close();
            }
        }

        //public void RemoveFromShelf(int moved, int id)
        //{
        //    if (ConnOpen())
        //    {
        //        query = "UPDATE `product` SET `in_stock` = `in_stock`+@amount WHERE `id` = @id;";
        //        SqlQuery(query);
        //        AddWithValue("amount", moved);
        //        AddWithValue("id", id);
        //        NonQueryEx();

        //        Close();

        //    }
        //    else
        //    {
        //        Close();
        //    }
        //}

        //public bool Remove(Product product)
        // {
        //     if (ConnOpen())
        //     {

        //         query = "DELETE from products WHERE id = @id";
        //         SqlQuery(query);
        //         AddWithValue("@id", product.ID);
        //         NonQueryEx();

        //         Close();
        //         return true;
        //     }
        //     else
        //     {
        //         Close();
        //         return false;
        //     }
        // }
        
        public bool Update(Product product)
        {
            if (ConnOpen())
            {
                query = "UPDATE products SET name = @name, brand = @brand, cost_price = @costPrice," +
                    " selling_price = @sellingPrice," +
                    " in_stock = @inStock, max_capacity = @maxCapacity," +
                    " threshold = @threshold WHERE id = @id";

                SqlQuery(query);
                AddWithValue("@name", product.Name);              
                AddWithValue("brand", product.Brand);     
              // TO DO: AddWithValue("@category", product.Category);
                AddWithValue("@costPrice", product.CostPrice);
                AddWithValue("@sellingPrice", product.SellPrice);
                AddWithValue("@inStock", product.InStock);
                AddWithValue("@maxCapacity", product.MaxCapacity);
                AddWithValue("@threshold", product.Threshold);
               // AddWithValue("@measurements", product.Measurements);
               // AddWithValue("@box_size", product.BoxSize);
                AddWithValue("@id", product.ID);

                NonQueryEx();

                Close();
                return true;
            }
            else
            {
                Close();
                return false;
            }
        }
        public List<Product> GetAll()
        {
            if (ConnOpen())
            {
                query = "SELECT * FROM products";
                SqlQuery(query);

                List<Product> products = new List<Product>();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Product product = new Product(
                        reader["name"].ToString(),
                        reader["brand"].ToString(),
                        Convert.ToDecimal(reader["cost_price"]),
                        Convert.ToDecimal(reader["selling_price"]),
                        Convert.ToInt32(reader["in_stock"]),
                        Convert.ToInt32(reader["max_capacity"]),
                        Convert.ToInt32(reader["threshold"]),
                        Convert.ToInt32(reader["sold"])
                      
                        );
                    product.ID = Convert.ToInt32(reader["id"]);
                    products.Add(product);
                }
                Close();
                return products;
            }
            else
            {
                Close();
                return null;
            }
        }
    }
}
