using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaBazaarWebsite.models
{
    public class Employee:User
    {
        public string DepartureReason
        {
            get;set;
        }
        public int ID
        {
            get; set;
        }

        public string FirstName
        {
            get; set;
        }
        public string LastName
        {
            get; set;
        }
 
        public string Email
        {
            get; set;
        }
        public string FirstWorkingDate
        {
            get; set;
        }
        public string LastWorkingDate
        {
            get; set;
        }
        public string Birthdate
        {
            get; set;
        }
        public string ContractType
        {
            get; set;
        }
        public double HourlyWage
        {
            get; set;
        }
     
        public string Address
        {
            get; set;
        }
        public string Department
        {
            get; set;
        }
        public string Role
        {
            get; set;
        }
        public int BSN
        {
            get; set;
        }
    
        public Employee(int id, string firstName, string lastName, int BSN, string email,
    string firstWorkingDate, string lastWorkingDate, string birthdate,
    string contractType, double hourlyWage, string address,
    string department, string role, string username, string password)
        {
            this.ID = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.BSN = BSN;
            this.Email = email;
            this.FirstWorkingDate = firstWorkingDate;
            this.LastWorkingDate = lastWorkingDate;
            this.Birthdate = birthdate;
            this.ContractType = contractType;
            this.HourlyWage = hourlyWage;
            this.Address = address;
            this.Department = department;
            this.Role = role;
            this.Username = username;
            this.Password = password;
        }


        public void UpdateInfo(string firstName, string lastName, string email,
            string contractType, string address,
            string department)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
            this.ContractType = contractType;
            this.Address = address;
            this.Department = department;
        }

        public void UpdateCredential(string password)
        {
            this.Password = password;
        }
    }
}
