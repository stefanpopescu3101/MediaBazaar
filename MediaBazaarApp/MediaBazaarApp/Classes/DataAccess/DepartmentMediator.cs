using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaarApp
{
    public class DepartmentMediator:DataAccess
    {

        public bool Add(Department department)
        {
            if (ConnOpen())
            {
                query = "INSERT INTO departments (name, manager_id) VALUES (@name, @manager_id)";

                SqlQuery(query);

                AddWithValue("@name", department.DepartmentName);
                AddWithValue("@manager_id", department.ManagerID);
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

        public List<Department> GetAll()
        {
            if (ConnOpen())
            {
                query = "SELECT * FROM departments";
                SqlQuery(query);
                List<Department> departments = new List<Department>();
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    Department department = new Department(
                    dataReader["name"].ToString(), Convert.ToInt32(dataReader["manager_id"]));
                    departments.Add(department);
                }
                Close();
                return departments;

            }
            else
            {
                Close();
                return null;
            }
        }

        public bool Remove(Department department)
        {
            if (ConnOpen())
            {
                query = "DELETE from departments WHERE name = @name";
                SqlQuery(query);
                AddWithValue("@name", department.DepartmentName);
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

        public bool Update(string departmentName, Employee departmentManager)
        {
            if (ConnOpen())
            {
                query = "UPDATE departments SET name = @name, manager_id = @manager_id WHERE name =@name";

                SqlQuery(query);
                AddWithValue("@name", departmentName);
                AddWithValue("@manager_id", departmentManager.ID);
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
