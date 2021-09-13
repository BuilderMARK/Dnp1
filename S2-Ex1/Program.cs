using System;

namespace S2_Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new FullTimeEmployee("mark", 1000);
            Employee employee2 = new PartTimeEmployee("mark1", 10, 3);
            Company company = new Company();
            company.HireNewEmployee(employee1);
            company.HireNewEmployee(employee2);
            company.GetMoneySalaryTotral();
        }
    }
}