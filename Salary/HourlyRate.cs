using System;
using System.Collections.Generic;
using System.Text;

namespace Salary
{
    class HourlyRate : FixedRateEmployee
    {
        private double hours;
        public HourlyRate(double accural, double hours) : base(accural)
        {
            this.hours = hours;
        }
        public double HoursRate()
        {
            return hours * SalaryAccrual();
        }
    }
}
