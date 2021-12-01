using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaBazaarWebsite.models
{
    public class EmployeeMediator:DataAccess,IEmployeeMediator
    {
        public List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>();

            if (ConnOpen())
            {
                try
                {
                    query = "SELECT * FROM employees";
                    SqlQuery(query);

                    MySqlDataReader dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        Employee employee = employee = new Employee(Convert.ToInt32(dataReader["id"]), dataReader["first_name"].ToString(), dataReader["last_name"].ToString(), Convert.ToInt32(dataReader["BSN"]), dataReader["email"].ToString(), dataReader["first_working_date"].ToString(), dataReader["last_working_date"].ToString(), dataReader["birthdate"].ToString(), dataReader["contract_type"].ToString(), Convert.ToDouble(dataReader["hourly_wage"]), dataReader["address"].ToString(), dataReader["department"].ToString(), dataReader["departure_reason"].ToString(), dataReader["role"].ToString(), dataReader["username"].ToString(), dataReader["password"].ToString(), dataReader["unavailableDay"].ToString());
                        employees.Add(employee);
                    }
                    dataReader.Close();
                    return employees;
                }
                catch (Exception)
                {
                    return null;
                }
                finally
                {
                    Close();
                }
            }
            
            return employees;
        }

        public bool UpdateUavailblityOfWorkshifts(Employee employee)
        {
            if (ConnOpen())
            {
                query = "UPDATE employees SET unavailableDay = @unavailableDay WHERE id = @id";

                SqlQuery(query);
                AddWithValue("@unavailableDay", employee.UnAvailableDay);
                AddWithValue("@id", employee.ID);
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
