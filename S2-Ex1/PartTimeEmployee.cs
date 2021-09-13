namespace S2_Ex1
{
    public class PartTimeEmployee : Employee
    {
        public double HourlyWage;
        public int HoursPerMonth;

        public PartTimeEmployee(string name, double hourlyWage, int hoursPerMonth) : base(name)
        {
            HourlyWage = hourlyWage;
            HoursPerMonth = hoursPerMonth;
        }

        public double HourlyWage1
        {
            get => HourlyWage;
            set => HourlyWage = value;
        }

        public int HoursPerMonth1
        {
            get => HoursPerMonth;
            set => HoursPerMonth = value;
        }

        public override double GetMonthlySalary()
        {
            return HourlyWage * HoursPerMonth;
        }
    }
}