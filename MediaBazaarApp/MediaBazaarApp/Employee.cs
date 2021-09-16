using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaarApp
{
    public class Employee : User
    {
        private string firstName;
        private string lastName;
        private int BSN;
        private string email;
        private string gender;
        private string firstWorkingDate;
        private string lastWorkingDate;
        private string birthdate;
        private string contractType;
        private int id;
        private double hourlyWage;
        private string departureReason;
        private int shiftsPerWeek;
        private string streetName;
        private int streetNumber;
        private string zipCode;
        private string town;
        private string country;
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
        public Employee(string username,string password, string firstName, string lastName, int BSN, string email,
            string gender, string firstWorkingDate, string lastWorkingDate, string birthdate,
            string contractType, double hourlyWage, string streetName, int streetNumber, string zipCode, string town, string country,
            string department, string role):base(username,password)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.BSN = BSN;
            this.email = email;
            this.gender = gender;
            this.firstWorkingDate = firstWorkingDate;
            this.lastWorkingDate = lastWorkingDate;
            this.birthdate = birthdate;
            this.contractType = contractType;
            this.hourlyWage = hourlyWage;
            this.streetName = streetName;
            this.streetNumber = streetNumber;
            this.zipCode = zipCode;
            this.town = town;
            this.country = country;
            this.department = department;
            this.role = role;
        }
        public void EditDetails(string username, string password, string firstName, string lastName, int BSN, string email,
            string gender, string firstWorkingDate, string lastWorkingDate, string birthdate,
            string contractType, double hourlyWage, string streetName, int streetNumber, string zipCode, string town, string country,
            string department, string role)
        {
            this.username = username;
            this.password = password;
            this.firstName = firstName;
            this.lastName = lastName;
            this.BSN = BSN;
            this.email = email;
            this.gender = gender;
            this.firstWorkingDate = firstWorkingDate;
            this.lastWorkingDate = lastWorkingDate;
            this.birthdate = birthdate;
            this.contractType = contractType;
            this.hourlyWage = hourlyWage;
            this.streetName = streetName;
            this.streetNumber = streetNumber;
            this.zipCode = zipCode;
            this.town = town;
            this.country = country;
            this.department = department;
            this.role = role;
        }

        public void TerminateContract(string reason,string lastWorkingDate)
        {
            this.DepartureReason = reason;
            this.lastWorkingDate = lastWorkingDate;
        }
        public override string ToString()
        {
            return "ID:" + " " + this.id + " " + "Name: " + this.firstName + " " + this.lastName  + " Contract: " + this.contractType;
        }
    }
}
