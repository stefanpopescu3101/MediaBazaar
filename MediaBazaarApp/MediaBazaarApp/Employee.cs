using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaarApp
{

    public class Employee:User
    {
        private int id;

        private string firstName;
        private string lastName;
        private int BSN;
        private string email;

        private string firstWorkingDate;
        private string lastWorkingDate;
        private string birthdate;
        private string contractType;

        private double hourlyWage;
        private string departureReason;
        private int shiftsPerWeek;
        private string address;

        private string department;
        private string role;

        public string DepartureReason
        {
            get { return departureReason; }
            set { departureReason = value; }
        }
        public int ID
        {
            get { return id; }
        }
        public string Name
        {
            get { return firstName+" "+lastName; }
        }

        public string FirstName
        {
            get { return firstName; }
        }
        public string LastName
        {
            get { return lastName; }
        }
        public int Bsn
        {
            get { return BSN; }
        }
        public string Email
        {
            get { return email; }
        }
        public string FirstWorkingDate
        {
            get { return firstWorkingDate; }
        }
        public string LastWorkingDate
        {
            get { return lastWorkingDate; }
        }
        public string Birthdate
        {
            get { return birthdate; }
        }
        public string ContractType
        {
            get { return contractType; }
        }
        public double HourlyWage
        {
            get { return hourlyWage; }
        }
        public int ShiftsPerWeek
        {
            get { return shiftsPerWeek; }
        }
        public string Address
        {
            get { return address; }
        }
        public string Department
        {
            get { return department; }set { department = value;  }
        }
        public string Role
        {
            get { return role; } set { role = value; }
        }

        public Employee(string firstName, string lastName, int BSN, string email,
            string firstWorkingDate, string lastWorkingDate, string birthdate,
            string contractType, double hourlyWage, string address,
            string department,string role)

        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.BSN = BSN;
            this.email = email;


            this.firstWorkingDate = firstWorkingDate;
            this.lastWorkingDate = lastWorkingDate;
            this.birthdate = birthdate;
            this.contractType = contractType;
            this.hourlyWage = hourlyWage;

            this.address = address;
            this.department = department;
            this.role = role;
        }
        public Employee(int id,string firstName, string lastName, int BSN, string email,
    string firstWorkingDate, string lastWorkingDate, string birthdate,
    string contractType, double hourlyWage, string address,
    string department,string role)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.BSN = BSN;
            this.email = email;
            this.firstWorkingDate = firstWorkingDate;
            this.lastWorkingDate = lastWorkingDate;
            this.birthdate = birthdate;
            this.contractType = contractType;
            this.hourlyWage = hourlyWage;
            this.address = address;
            this.department = department;
            this.role = role;
        }


      

        //public void EditDetails(string firstName, string lastName, int BSN, string email,
        //    string firstWorkingDate, string lastWorkingDate, string birthdate,
        //    string contractType, double hourlyWage, string address,
        //    string department)
        //{
        //    this.firstName = firstName;
        //    this.lastName = lastName;
        //    this.BSN = BSN;
        //    this.email = email;
        //    this.firstWorkingDate = firstWorkingDate;
        //    this.lastWorkingDate = lastWorkingDate;
        //    this.birthdate = birthdate;
        //    this.contractType = contractType;
        //    this.hourlyWage = hourlyWage;
        //    this.address = address;
        //    this.department = department;
        //}

        public void TerminateContract(string reason, string lastWorkingDate)

        {
            this.DepartureReason = reason;
            this.lastWorkingDate = lastWorkingDate;
        }

        public void UpdateInfo(string firstName, string lastName, string email,
            string contractType, string address,
            string department)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.contractType = contractType;
            this.address = address;
            this.department = department;
        }

        public override string ToString()
        {
            return "ID:" + " " + this.id + " " + "Name: " + this.firstName + " " + this.lastName  + " Contract: " + this.contractType;
        }
    }
}
