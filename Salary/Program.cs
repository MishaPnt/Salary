﻿using System;
namespace Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the rate salary: ");
            double rate = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the initials of employee: ");
            string nameOfEmployee = Console.ReadLine();
            Employee employeeHourlyRate = new EmployeeHourlyRate(rate,nameOfEmployee);
            Console.WriteLine($"Salary Of {employeeHourlyRate.Name()} is {employeeHourlyRate.Salary()}");
            Console.WriteLine("\tEmployee with hourly rate");
            Console.WriteLine("Enter the accrual salary: ");
            double rate1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the working hours: ");
            double hours = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the initials of employee: ");
            string nameOfEmployee1 = Console.ReadLine();
            Employee hourlyRate = new EmployeeHourlyRate(hours,rate1,nameOfEmployee1);
            Console.WriteLine($"Salary Of {hourlyRate.Name()} is {hourlyRate.Salary()}");
            Console.WriteLine("\tEmployee in the state");
            Console.WriteLine("Enter the initials of employee: ");
            string nameOfEmployee2 = Console.ReadLine();
            Console.WriteLine("Workplace: ");
            string workplace = Console.ReadLine();
            Console.WriteLine("Fixed rate:");
            double rate2 = double.Parse(Console.ReadLine());
            Employee employeeInState = new EmployeeInState(workplace,rate,nameOfEmployee2);
            Console.WriteLine($"{employeeInState.Name()} working in {employeeInState.Workplace()}. Rate is {employeeInState.Salary()}");
            Console.WriteLine("\tPercent Rate of employee ");
            Console.WriteLine("Enter the initials of employee: ");
            string nameOfEmployee3 = Console.ReadLine();
            Console.WriteLine("Fixed rate:");
            double rate3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter how many percents:");
            double percent = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter how many days:");
            int days = int.Parse(Console.ReadLine());
            Employee employeePercentRate = new EmployeePercentRate(percent, days,rate3,nameOfEmployee3);
            Console.WriteLine($"{employeePercentRate.Name()}. Rate is {employeePercentRate.Salary()}");
        }
    }
}
