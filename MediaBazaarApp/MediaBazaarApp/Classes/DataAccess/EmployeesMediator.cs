using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MediaBazaarApp
{
    class EmployeesMediator : DataAccess
    {
        private DataAccess dataAccess;

        public EmployeesMediator()
        {
            //try
            //{
            //    dataAccess = new DataAccess();
            //    dataAccess.ConnOpen();
            //}
            //catch(Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            dataAccess = new DataAccess();
        }

        public bool AddEmployee(Employee employee)
        {
            if (ConnOpen())
            {
                try
                {
                    query = "INSERT INTO employees (first_name, last_name, BSN, email, first_working_date, last_working_date, birthdate, contract_type, hourly_wage, departure_reason, shifts_per_week, address, department, role) VALUES ( @firstName, @lastName, @BSN, @email, @firstWorkingDate, @lastWorkingDate, @birthdate, @contractType, @hourlyWage, @departureReason, @shiftsPerWeek, @address, @department, @role)";

                    SqlQuery(query);
                
                    AddWithValue("@firstName", employee.FirstName);
                    AddWithValue("@lastName", employee.LastName);
                    AddWithValue("@BSN", employee.Bsn);
                    AddWithValue("@email", employee.Email);
                    AddWithValue("@firstWorkingDate", employee.FirstWorkingDate);
                    AddWithValue("@lastWorkingDate", employee.LastWorkingDate);
                    AddWithValue("@birthdate", employee.Birthdate);
                    AddWithValue("@contractType", employee.ContractType);
                    AddWithValue("@hourlyWage", employee.HourlyWage);
                    AddWithValue("@departureReason", employee.DepartureReason);
                    AddWithValue("@shiftsPerWeek", employee.ShiftsPerWeek);
                    AddWithValue("@address", employee.Address);
                    AddWithValue("@department", employee.Department);
                    AddWithValue("@role", employee.Role);
                    //employee.ID = Convert.ToInt32(command.LastInsertedId);
                    NonQueryEx();
                    employee.ID = Convert.ToInt32(command.LastInsertedId);
                    query = "INSERT INTO unavailability (employee_id) VALUES (@employee_id)";
                    SqlQuery(query);
                    AddWithValue("@employee_id", employee.ID);
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

        public bool RemoveEmployee(Employee emp)
        {
            if (ConnOpen())
            {
               
                    query = "DELETE from employees WHERE id = @id";
                    SqlQuery(query);
                    AddWithValue("@id", emp.ID);
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

        public bool Update(Employee employee)
        {
            if (ConnOpen())
            {
                query = "UPDATE employees SET first_name = @firstName, last_name = @lastName, email = @email, contract_type = @contractType, address = @address, department = @department WHERE id = @id";
                 
                SqlQuery(query);
                AddWithValue("@id", employee.ID);
                AddWithValue("@firstName", employee.FirstName);
                AddWithValue("@lastName", employee.LastName);
                AddWithValue("@email", employee.Email);
                AddWithValue("@contractType", employee.ContractType);
                AddWithValue("@address", employee.Address);
                AddWithValue("@department", employee.Department);
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
        public bool UpdateUsernameAndPassword(Employee employee)
        {
            if (ConnOpen())
            {
                query = "UPDATE employees SET username = @username, password = @password WHERE id = @id";

                SqlQuery(query);
                AddWithValue("@username", employee.UserName);
                AddWithValue("@password", employee.Password);
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
                        Employee employee = employee = new Employee(Convert.ToInt32(dataReader["id"]),dataReader["first_name"].ToString(), dataReader["last_name"].ToString(), Convert.ToInt32(dataReader["BSN"]), dataReader["email"].ToString(), dataReader["first_working_date"].ToString(), dataReader["last_working_date"].ToString(), dataReader["birthdate"].ToString(), dataReader["contract_type"].ToString(), Convert.ToDouble(dataReader["hourly_wage"]), dataReader["address"].ToString(), dataReader["department"].ToString(), dataReader["departure_reason"].ToString(), dataReader["role"].ToString(),dataReader["username"].ToString(),dataReader["password"].ToString());
                        employees.Add(employee);
                    }
                    dataReader.Close();
                    return employees;
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
            return employees;
        }
        public List<Employee> GetEmployeesOfDepartment(Department depart)
        {
            List<Employee> employees = new List<Employee>();

            if (ConnOpen())
            {
                try
                {
                    query = "SELECT * FROM employees WHERE department =@department";
                    SqlQuery(query);
                    this.AddWithValue("@department",depart.DepartmentName );
                    MySqlDataReader dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        Employee employee = employee = new Employee(Convert.ToInt32(dataReader["id"]), dataReader["first_name"].ToString(), dataReader["last_name"].ToString(), Convert.ToInt32(dataReader["BSN"]), dataReader["email"].ToString(), dataReader["first_working_date"].ToString(), dataReader["last_working_date"].ToString(), dataReader["birthdate"].ToString(), dataReader["contract_type"].ToString(), Convert.ToDouble(dataReader["hourly_wage"]), dataReader["address"].ToString(), dataReader["department"].ToString(), dataReader["departure_reason"].ToString(), dataReader["role"].ToString(),dataReader["username"].ToString(),dataReader["password"].ToString());
                        employees.Add(employee);
                    }
                    dataReader.Close();
                    return employees;
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
            return employees;
        }
        public bool UpdateRoleAndDepartment(Employee emp, string department, string role)
        {
            if (ConnOpen())
            {
                query = "UPDATE employees SET department = @department, role = @role WHERE id =@id";

                SqlQuery(query);
                AddWithValue("@department", department);
                AddWithValue("@role", role);
                AddWithValue("@id", emp.ID);
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

        public bool TerminateContract(Employee emp, string endDate, string reason)
        {
            if (ConnOpen())
            {
                query = "UPDATE employees SET last_working_date = @endDate, departure_reason = @reason WHERE id = @id";

                SqlQuery(query);
                AddWithValue("@endDate", endDate);
                AddWithValue("@reason", reason);
                AddWithValue("@id", emp.ID);
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
