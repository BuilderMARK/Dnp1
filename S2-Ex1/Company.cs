using System;
using System.Collections.Generic;

namespace S2_Ex1
{
    public class Company
    {
        public Employee emp;
        public List<Employee> Employees = new();
        public double GetMoneySalaryTotral()
        {
            double sum = 0;
            foreach (var test in Employees)
            {
                sum = sum + test.GetMonthlySalary();
                
            }

            return sum;

        }

        public void HireNewEmployee(Employee emp) => Employees.Add(emp);
    }
}