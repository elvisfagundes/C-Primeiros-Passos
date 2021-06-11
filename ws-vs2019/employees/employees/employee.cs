using System;
using System.Globalization;

namespace employees
{
    class employee
    {
        public int Ident { get; set; }
        public string Name { get; set; }
        public double Salary { get; private set; }
        public employee(int ident, string name, double salary)
        {
            Ident = ident;
            Name = name;
            Salary = salary;
        }
        public void IncreaseSalary(double percentage)
        {

            Salary += Salary * percentage / 100.0;
            
        }
        public override string ToString()
        {
            return Ident + ", " + Name + ", " + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }
    }   
    
}
