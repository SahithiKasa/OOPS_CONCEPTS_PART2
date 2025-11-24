using System;

namespace CTM
{
    //method overloading -- compile polymorphisam
    class SalaryCalculator
    {

        //static void Main()
        //{

        //}
        public double CalculateSalary(double monthlySalary)
        {
            return monthlySalary;
        }

        public double CalculateSalary(int monthlySalary)
        {
            return monthlySalary;
        }

        public double CalculateSalary(int hoursworked, int hoursRate)
        {
            return hoursworked * hoursRate;
        }

        public double CalculateSalary(double salesAmount, double commissionRate)
        {
            return salesAmount * commissionRate;
        }
        public double CalculateSalary(int hoursWorked, int hourlyRate, double bonus)
        {
            return (hoursWorked * hourlyRate) + bonus;
        }

    }


    class Program
    {
        static void Main()
        {
            SalaryCalculator salaryCalculator = new SalaryCalculator();
            //salaryCalculator.CalculateSalary()

            double salary1 = salaryCalculator.CalculateSalary(10000.09);
            double salary2 = salaryCalculator.CalculateSalary(10000);
            double salary3 = salaryCalculator.CalculateSalary(9, 4);
            double salary4 = salaryCalculator.CalculateSalary(5000, 0.1);
            double salary5 = salaryCalculator.CalculateSalary(9, 4, 100);

            Console.WriteLine($"Salary 1: {salary1}"); // Output: Salary 1: 10000.09
            Console.WriteLine($"Salary 2: {salary2}"); // Output: Salary 1: 
            Console.WriteLine($"Salary 3: {salary3}"); // Output: Salary 1: 
            Console.WriteLine($"Salary 4: {salary4}"); // Output: Salary 1: 
            Console.WriteLine($"Salary 5: {salary5}"); // Output: Salary 1: 



        }
    }
}