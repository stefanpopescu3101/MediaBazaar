using System;
using System.Collections.Generic;
using System.Text;

namespace MediaBazaarApp
{ 
    public class StatisticsManager
    {
        List<Employee> employees;
        StatisticsMediator statisticsMediator;
        EmployeesMediator employeesMediator;
        

        public StatisticsManager()
        {
            employees = new List<Employee>();
            statisticsMediator = new StatisticsMediator();
            employeesMediator = new EmployeesMediator();
        }

        public int GetPartTimeEmp()
        {
            return statisticsMediator.GetPartTimeEmp();
        }

        public int GetFullTimeEmp()
        {
            return statisticsMediator.GetFullTimeEmp();
        }

        public List<Employee> GetTerminatedEmployees()
        {
            return statisticsMediator.GetTerminatedEmployees();
        }

        public List<Employee> GetEmployeesHoursWorked()
        {
            return statisticsMediator.GetEmployeesHoursWorked();
        }
        public List<WorkShift> GetEmployeeHoursWorked(int id)
        {
            return statisticsMediator.GetEmployeeHoursWorked(id);
        }
    }
}
