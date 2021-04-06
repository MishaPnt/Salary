namespace Salary
{
    class EmployeeHourlyRate : EmployeeFixedRate
    {
        private double hours;
        public EmployeeHourlyRate(double accrual, double hours) : base(accrual)
        {
            this.hours = hours;
        }
        public double HoursRate()
        {
            return hours * SalaryAccrual();
        }
    }
}
