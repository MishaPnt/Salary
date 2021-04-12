namespace Salary
{
    class EmployeePercentRate : Employee
    {
        private double percent;
        private int days;
        public EmployeePercentRate(double percent,int days,double rate, string nameOfEmployee) : base(rate, nameOfEmployee)
        {
            this.percent = percent;
            this.days = days;
        }
        public override double Salary()
        {
            return days * rate * percent / 100;
        }
    }
}
