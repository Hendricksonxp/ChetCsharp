﻿namespace AdsPayroll
{
    public class Payroll
    {
        Employees employees = new Employees();
        public void AddEmployee(Employee employee)
        {
            employees.Add(employee);
        }

        public void Pay(string payDate)
        {

        }
    }
}