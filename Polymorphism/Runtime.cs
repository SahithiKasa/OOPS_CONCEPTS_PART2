using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace RuntimePolyContainer
{

    //virual - override
    class Employee
    {
        public string Name { get; set; }
        public int HoursWorked { get; set; }
        public double HourlyRate { get; set; }

        public virtual double CalculateSalary()
        {
            return HoursWorked * HourlyRate; // Default calculation
        }
        public void DisplayDetails()
        {
            Console.WriteLine($"Employee Name: {Name}");
            Console.WriteLine($"Hours Worked: {HoursWorked}");
            Console.WriteLine($"Hourly Rate: {HourlyRate:c}");
        }

    }

    class PermanentEmployee : Employee
    {
        //public PermanentEmployee()
        //{
        //    HoursWorked = 5;
        //    HourlyRate = 
        //}

        public override double CalculateSalary()
        {
            double baseSalary = HoursWorked * HourlyRate;
            double bonus = baseSalary * 0.2; // 20% bonus
            return baseSalary + bonus;
        }
    }

    class ContractEmployee : Employee
    {
        public override double CalculateSalary()
        {
            double baseSalary = HoursWorked * HourlyRate;
            double deductions = baseSalary * 0.1; // 10% deductions
            return baseSalary - deductions;
        }
    }


    class Program
    {
        static void Main()
        {
            //Employee employee = new Employee();
            //employee.CalculateSalary();

            Employee employee1 = new PermanentEmployee()
            {
                Name = "Alice",
                HoursWorked = 160,
                HourlyRate = 50
            };
            double AliceSalary = employee1.CalculateSalary();
            Console.WriteLine(AliceSalary);



            Employee employee2= new ContractEmployee()
            {
                Name = "Bob",
                HoursWorked = 140,
                HourlyRate = 40
            };
            double BobSalary = employee2.CalculateSalary();
            Console.WriteLine(BobSalary);
            employee1.DisplayDetails();
            employee2.DisplayDetails();
            
            

        }

    }

}