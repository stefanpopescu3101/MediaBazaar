using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaarApp
{
    public class ProductMediator
    {
        /* public bool Add(Product product)
         {
             if(Connection is open)
             {
                 query = "INSERT INTO product(name, category,cost_price,selling_price,in_stock,max_capacity,threshold,sold,size)" +
                     "VALUE (@name, @category, @costPrice,@sellingPrice,@inStock,@maxCapacity,@threshold,@sold,@size)";
                 SqlQuery(query);

                 AddWithValue("@name", product.Name);
                 AddWithValue("@category", product.Category);
                 AddWithValue("@costPrice", product.costPrice);
                 AddWithValue("@sellingPrice", product.sellingPrice);
                 AddWithValue("@inStock", product.sellingPrice);
                 AddWithValue("@maxCapacity", product.maxCapacity);
                 AddWithValue("@threshold", product.threshold);
                 AddWithValue("@sold", product.sold);
                 AddWithValue("@size", product.size);

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
         public bool Remove(Product product)
         {
             if (Connection is open)
             {
                 query = "DELETE from product WHERE id = @id";
                 SqlQuery(query);
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
        
        public bool Update(Product product)
        {
            if (Connection is open)
            {
                query = "UPDATE product SET name = @name, category = @category, costPrice = @costPrice, sellingPrice = @sellingPrice, inStock = @inStock, maxCapacity = @maxCapacity, threshold = @threshold, sold = @sold, size = @size WHERE id = @id";

                SqlQuery(query);
                AddWithValue("@name", product.Name);
                AddWithValue("@category", product.Category);
                AddWithValue("@costPrice", product.CostPrice);
                AddWithValue("@sellingPrice", product.SellingPrice);
                AddWithValue("@inStock", product.inStock);
                AddWithValue("@maxCapacity", product.maxCapacity);
                AddWithValue("@threshold", product.Threshold);
                AddWithValue("@sold", product.Sold);
                AddWithValue("@size", product.Size);

               
                //Non query execute

                Close();
                return true;
            }
            else
            {
                Close();
                return false;
            }
        }*/
    }
}
