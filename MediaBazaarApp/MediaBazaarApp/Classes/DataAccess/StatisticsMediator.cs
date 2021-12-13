using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace MediaBazaarApp
{
    class StatisticsMediator : DataAccess
    {
        private DataAccess dataAccess;

        public StatisticsMediator()
        {
            dataAccess = new DataAccess();
        }

        public int GetPartTimeEmp()
        {
            int partTimeEmpNr = 0;
            if (ConnOpen())
            {
                query = "SELECT COUNT(*) AS pt_emp_nr FROM employees WHERE contract_type = 'Part Time'";
                SqlQuery(query);

                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    partTimeEmpNr = Convert.ToInt32(reader["pt_emp_nr"]);
                }
                Close();
                return partTimeEmpNr;

            }
            else
            {
                Close();
                return partTimeEmpNr;
            }
        }

        public int GetFullTimeEmp()
        {
            int fullTimeEmpNr = 0;
            if (ConnOpen())
            {
                query = "SELECT COUNT(*) AS ft_emp_nr FROM employees WHERE contract_type = 'Full Time'";
                SqlQuery(query);

                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    fullTimeEmpNr = Convert.ToInt32(reader["ft_emp_nr"]);
                }
                Close();
                return fullTimeEmpNr;

            }
            else
            {
                Close();
                return fullTimeEmpNr;
            }
        }

        public List<Employee> GetTerminatedEmployees()
        {
            List<Employee> employees = new List<Employee>();

            if (ConnOpen())
            {
                query = "SELECT * FROM employees WHERE departure_reason IS NOT NULL";
                SqlQuery(query);

                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    Employee employee = new Employee(Convert.ToInt32(dataReader["id"]), dataReader["first_name"].ToString(), dataReader["last_name"].ToString(), Convert.ToInt32(dataReader["BSN"]), dataReader["email"].ToString(), dataReader["first_working_date"].ToString(), dataReader["last_working_date"].ToString(), dataReader["birthdate"].ToString(), dataReader["contract_type"].ToString(), Convert.ToDouble(dataReader["hourly_wage"]), dataReader["address"].ToString(), dataReader["department"].ToString(), dataReader["departure_reason"].ToString(), dataReader["role"].ToString(), dataReader["username"].ToString(), dataReader["password"].ToString());
                    employees.Add(employee);
                }
                Close();
                return employees;

            }
            else
            {
                Close();
                return employees;
            }
        }

        public List<Employee> GetEmployeesHoursWorked()
        {
            List<Employee> employees = new List<Employee>();

            if (ConnOpen())
            {
                //query = "SELECT workshifts.employeeID, employees.first_name, employees.last_name, SUM(workshifts.hoursWorked) AS hours FROM workshifts INNER JOIN employees ON workshifts.employeeID=employees.id GROUP BY workshifts.employeeID";
                query = "SELECT employeeID, SUM(hoursWorked) AS hours FROM workshifts GROUP BY employeeID";

                SqlQuery(query);

                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    Employee employee = new Employee(Convert.ToInt32(dataReader["employeeID"]),Convert.ToInt32(dataReader["hours"]));
                    employees.Add(employee);
                }
                Close();
                return employees;

            }
            else
            {
                Close();
                return employees;
            }
        }


        public List<WorkShift> GetEmployeeHoursWorked(int id)
        {
            List<WorkShift> hoursPerMonth = new List<WorkShift>();

            if (ConnOpen())
            {
                //query = "SELECT workshifts.employeeID, employees.first_name, employees.last_name, SUM(workshifts.hoursWorked) AS hours FROM workshifts INNER JOIN employees ON workshifts.employeeID=employees.id GROUP BY workshifts.employeeID";
                query = "SELECT employeeID,type, SUM(hoursWorked) AS hours FROM workshifts WHERE employeeID="+id+" GROUP BY type";

                SqlQuery(query);

                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    WorkShift month = new WorkShift(Convert.ToInt32(dataReader["employeeID"]), dataReader["type"].ToString(),Convert.ToInt32(dataReader["hours"]));
                    hoursPerMonth.Add(month);
                }
                Close();
                return hoursPerMonth;

            }
            else
            {
                Close();
                return hoursPerMonth;
            }
        }


    }
}
