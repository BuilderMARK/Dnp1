namespace S2_Ex1
{
    public abstract class Employee
    {
        public string name;

        protected Employee(string name)
        {
            this.name = name;
        }

        public abstract double GetMonthlySalary();


    }
}