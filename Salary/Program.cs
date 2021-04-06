using System;

namespace Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the accural salary: ");
            double accural = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the initials of employee: ");
            string employee = Console.ReadLine();
            Console.WriteLine("Enter the rate of employee: ");
            double salaryRate = double.Parse(Console.ReadLine());
            FixedRateEmployee fixedRate = new FixedRateEmployee(accural);
            fixedRate.Employee = employee;
            fixedRate.SalaryRate = salaryRate;
            Console.WriteLine($"Salary Of {fixedRate.Employee} is {fixedRate.SalaryRate}");
            Console.WriteLine("-----------\t\t----------");
            Console.WriteLine("Employee with hourly rate:");
            double accural1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the working hours: ");
            double hours = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the initials of employee: ");
            string employee1 = Console.ReadLine();
            HourlyRate hourlyRate = new HourlyRate(accural1, hours);
            hourlyRate.Employee = employee1;
            Console.WriteLine($"Salary Of {hourlyRate.Employee} is {hourlyRate.HoursRate()}");
            
            
        }
    }
}
