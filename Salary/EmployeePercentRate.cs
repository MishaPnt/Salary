namespace Salary
{
    class EmployeePercentRate : EmployeeFixedRate
    {
        private double accrual;
        private double percent;
        private int days;
        public EmployeePercentRate(double accrual, double percent,int days) : base(accrual)
        {
            this.accrual = accrual;
            this.percent = percent;
            this.days = days;
        }
        public double Salary()
        {
            return days*8+accrual * (percent/100);
        }
    }
}
