namespace Salary
{
    class EmployeeInState : EmployeeFixedRate
    {
        private double accrual;
        public EmployeeInState(double accrual) : base(accrual)
        {
            this.accrual = accrual;
        }
        public string State { get; set; }
    }
}
