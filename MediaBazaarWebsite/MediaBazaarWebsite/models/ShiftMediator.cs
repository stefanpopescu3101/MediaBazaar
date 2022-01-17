using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaarWebsite.models
{
    public class ShiftMediator:DataAccess,IWorkshiftMediator
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


        public List<UnavailableShift> GetAllUnavailable()
        {
            if (ConnOpen())
            {
                query = "SELECT * FROM unavailability ";
                SqlQuery(query);
                List<UnavailableShift> unavailableShifts = new List<UnavailableShift>();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    UnavailableShift unavailableShift = new UnavailableShift(
                        Convert.ToInt32(reader["employee_id"]), reader["unavailableDay"].ToString()
                        );

                    
                    unavailableShifts.Add(unavailableShift);
                }
                Close();
                return unavailableShifts;

            }
            else
            {
                Close();
                return null;
            }
        }

        public bool AddUnavailableShift(UnavailableShift unavailableShift)
        {
            if(ConnOpen())
            {
                query = "INSERT INTO unavailability (employee_id, unavailableDay) VALUES (@ID, @unavailableDay)";
                SqlQuery(query);

                AddWithValue("@ID", unavailableShift.EmployeeId);
                AddWithValue("@unavailableDay", unavailableShift.UnavailableDay);

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

      
      

       
    }
}
