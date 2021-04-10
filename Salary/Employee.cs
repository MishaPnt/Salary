namespace Salary
{
    abstract class Employee
    {
        protected double rate;
        protected string nameOfEmployee;
        public Employee(double rate,string nameOfEmployee)
        {
            this.rate = rate;
            this.nameOfEmployee = nameOfEmployee;
        }
        public abstract double Salary();
        public abstract string Name();
    }
}
