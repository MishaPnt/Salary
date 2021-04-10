namespace Salary
{
    class EmployeeHourlyRate : Employee
    {
        private double hours;
        public EmployeeHourlyRate(double hours,double rate,string nameOfEmployee) : base(rate,nameOfEmployee)
        {
            this.hours = hours;
        }

        public EmployeeHourlyRate(double rate, string nameOfEmployee) : base(rate, nameOfEmployee)
        {
        }

        public override double Salary()
        {
            return hours * rate;
        }
        public override string Name()
        {
            return nameOfEmployee; 
        }
    }
}
