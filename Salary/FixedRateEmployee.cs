using System;
using System.Collections.Generic;
using System.Text;

namespace Salary
{
    class FixedRateEmployee
    {
        private double accrual;
        public FixedRateEmployee(double accrual)
        {
            this.accrual = accrual;
        }
        public string Employee { get; set; }
        public double SalaryRate { get; set; }
        public double SalaryAccrual()
        {
            return SalaryRate + accrual;
        }
    }
}
