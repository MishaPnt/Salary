namespace Salary
{
    class EmployeeInState : Employee
    {
        private string workplace;
        public EmployeeInState(string workplace,double rate, string nameOfEmployee) : base(rate, nameOfEmployee)
        {
            this.workplace = workplace;
        }
        public override double Salary()
        {
            return rate;
        }
        public override string Name()
        {
            return nameOfEmployee;
        }
        public string Workplace()
        {
            return workplace;
        }
    }
}
