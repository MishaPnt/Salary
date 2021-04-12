namespace Salary
{
    class EmployeeHourlyRate : Employee
    {
        private double hours;
        public EmployeeHourlyRate(double hours,double rate,string nameOfEmployee) : base(rate,nameOfEmployee)
        {
            this.hours = hours;
        }
        public override double Salary()
        {
            return hours * rate;
        }
    }
}
