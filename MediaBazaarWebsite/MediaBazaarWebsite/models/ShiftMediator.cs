using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaarWebsite.models
{
    public class ShiftMediator:DataAccess
    {
      

       

        public List<WorkShift> GetAll()
        {
            if (ConnOpen())
            {
                query = "SELECT * FROM workshifts ";
                SqlQuery(query);
                List<WorkShift> workshifts = new List<WorkShift>();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    WorkShift workshift = new WorkShift(
                        Convert.ToInt32(reader["employeeID"]),
                        reader["employeeName"].ToString(),
                        reader["Date"].ToString(),
                        (reader["type"]).ToString(),
                        Convert.ToDecimal(reader["wageForShift"]),
                        Convert.ToInt32(reader["hoursWorked"]));

                    workshift.ID = Convert.ToInt32(reader["id"]);
                    if (reader["Cancelled"].ToString() == "True") { workshift.CancelShift(); }

                    workshifts.Add(workshift);
                }
                Close();
                return workshifts;

            }
            else
            {
                Close();
                return null;
            }
        }

      
      

       
    }
}
