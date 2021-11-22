using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MediaBazaarApp
{
    class ShelfMediator : DataAccess
    {
        private DataAccess dataAccess;

        public ShelfMediator()
        {
            dataAccess = new DataAccess();
        }

        public bool AddShelf(Shelf shelf)
        {
            if (ConnOpen())
            {
                try
                {
                    query = "INSERT INTO shelves (shelf_id, shelf_category, shelf_capacity) VALUES (@id, @category, @capacity)";

                    dataAccess.SqlQuery(query);

                    AddWithValue("@id", shelf.ID);
                    AddWithValue("@category", shelf.Category);
                    AddWithValue("@capacity", shelf.Capacity);


                    NonQueryEx();
                    Close();
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }

            }
            else return false;
        }

        public void RemoveShelf(int id)
        {
            Close();
            if (ConnOpen())
            {
                try
                {
                    query = "DELETE FROM shelves WHERE @id = " + id;
                    MySqlDataReader dataReader = command.ExecuteReader();

                    SqlQuery(query);
                    NonQueryEx();
                    dataReader.Close();


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }


        public List<Shelf> GetShelves()
        {
            List<Shelf> shelves = new List<Shelf>();

            if (ConnOpen())
            {
                try
                {
                    query = "SELECT * FROM shelves";
                    SqlQuery(query);

                    MySqlDataReader dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        Shelf shelf = shelf = new Shelf(Convert.ToInt32(dataReader["id"]), dataReader["shelf_category"].ToString(), Convert.ToInt32(dataReader["shelf_capacity"]));
                        shelves.Add(shelf);
                    }
                    dataReader.Close();
                    return shelves;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    Close();
                }
            }
            return shelves;
        }
    }
}
