using System;

namespace Encapsulation.Employment
{
    public class Employee
    {
        
        private string _firstName;
        private string _lastName;
        private double _monthlySalary;

        
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = !string.IsNullOrEmpty(value) ? value : "Unknown"; }
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = !string.IsNullOrEmpty(value) ? value : "Unknown"; }
        }

        public double MonthlySalary
        {
            get { return _monthlySalary; }
            set { if (value > 0) _monthlySalary = value; }
        }

        
        public Employee(string firstName, string lastName, double monthlySalary)
        {
            FirstName = firstName;
            LastName = lastName;
            MonthlySalary = monthlySalary > 0 ? monthlySalary : 0.0;
        }

       
        public void RaiseSalary(int raisePercentage)
        {
            if (raisePercentage > 0 && raisePercentage <= 20)
            {
                _monthlySalary += (_monthlySalary * raisePercentage) / 100;
            }
        }

        
        public double GetYearlySalary()
        {
            return _monthlySalary * 12;
        }
    }
}
