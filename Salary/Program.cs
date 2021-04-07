using System;
namespace Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the accrual salary: ");
            double accrual = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the initials of employee: ");
            string employee = Console.ReadLine();
            Console.WriteLine("Enter the rate of employee: ");
            double salaryRate = double.Parse(Console.ReadLine());
            EmployeeFixedRate fixedRate = new EmployeeFixedRate(accrual);
            fixedRate.Employee = employee;
            fixedRate.SalaryRate = salaryRate;
            Console.WriteLine($"Salary Of {fixedRate.Employee} is {fixedRate.SalaryAccrual()}");
            Console.WriteLine("\tEmployee with hourly rate");
            Console.WriteLine("Enter the accrual salary: ");
            double accrual1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the working hours: ");
            double hours = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the initials of employee: ");
            string employee1 = Console.ReadLine();
            EmployeeHourlyRate hourlyRate = new EmployeeHourlyRate(accrual1, hours);
            hourlyRate.Employee = employee1;
            Console.WriteLine($"Salary Of {hourlyRate.Employee} is {hourlyRate.HoursRate()}");
            Console.WriteLine("\tEmployee in the state");
            Console.WriteLine("Enter the initials of employee: ");
            string employee2 = Console.ReadLine();
            Console.WriteLine("Workplace: ");
            string state = Console.ReadLine();
            Console.WriteLine("Fixed rate:");
            double salaryRate1 = double.Parse(Console.ReadLine());
            EmployeeInState employeeInState = new EmployeeInState(salaryRate1);
            employeeInState.Employee = employee2;
            employeeInState.State = state;
            Console.WriteLine($"{employeeInState.Employee} working in {employeeInState.State}. Rate is {salaryRate1}");
            Console.WriteLine("\tPercent Rate of employee ");
            Console.WriteLine("Enter the initials of employee: ");
            string employee3 = Console.ReadLine();
            Console.WriteLine("Fixed rate:");
            double accrual2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter how many percents:");
            double percent = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter how many days:");
            int days = int.Parse(Console.ReadLine());
            EmployeePercentRate employeePercentRate = new EmployeePercentRate(accrual2, percent, days);
            employeePercentRate.Employee = employee3;
            Console.WriteLine($"{employeePercentRate.Employee}. Rate is {employeePercentRate.Salary()}");
        }
    }
}
