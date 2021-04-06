namespace Salary
{
    class EmployeeFixedRate
    {
        private double accrual;
        public EmployeeFixedRate(double accrual)
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
