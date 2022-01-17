using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaBazaarWebsite.models
{
    public class LoginMediator:DataAccess,ILoginMdiator
    {
        public LoginMediator() : base()
        {
           
        }

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
                        Employee employee = employee = new Employee(Convert.ToInt32(dataReader["id"]), dataReader["first_name"].ToString(), dataReader["last_name"].ToString(), Convert.ToInt32(dataReader["BSN"]), dataReader["email"].ToString(), dataReader["first_working_date"].ToString(), dataReader["last_working_date"].ToString(), dataReader["birthdate"].ToString(), dataReader["contract_type"].ToString(), Convert.ToDouble(dataReader["hourly_wage"]), dataReader["address"].ToString(), dataReader["department"].ToString(), dataReader["departure_reason"].ToString(), dataReader["role"].ToString(), dataReader["username"].ToString(), dataReader["password"].ToString());
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

        public Employee GetEmployee(string password, string username)
        {
            Employee emp;
            if (ConnOpen())
            {
                query = "SELECT * FROM employees WHERE password=@password And username=@username ";
                SqlQuery(query);
                AddWithValue("@password", password);
                AddWithValue("@password", username);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    
                        emp = new Employee(Convert.ToInt32(dataReader["id"]), dataReader["first_name"].ToString(), dataReader["last_name"].ToString(), Convert.ToInt32(dataReader["BSN"]), dataReader["email"].ToString(), dataReader["first_working_date"].ToString(), dataReader["last_working_date"].ToString(), dataReader["birthdate"].ToString(), dataReader["contract_type"].ToString(), Convert.ToDouble(dataReader["hourly_wage"]), dataReader["address"].ToString(), dataReader["department"].ToString(), dataReader["departure_reason"].ToString(), dataReader["role"].ToString(), dataReader["username"].ToString(), dataReader["password"].ToString());
                    Close();
                        return emp;

                    

                }
                return null;
            }
            else
            {
                Close();
                return null;
            }
        }

        public bool UpdatePassword(Employee employee)
        {
            if (ConnOpen())
            {
                query = "UPDATE employees SET password = @password WHERE id = @id";

                SqlQuery(query);
                AddWithValue("@id", employee.ID);
                AddWithValue("@password", employee.Password);
                NonQueryEx();

                Close();
                return true;
            }
            else
            {
                Close();
                return true;
            }
        }
    }
}
