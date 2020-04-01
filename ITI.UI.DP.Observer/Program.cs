using System;
using System.Diagnostics;

namespace ITI.UI.DP.Observer.EventHandler
{
    class SalaryEventArgs
    {
        public int NewSalary { get; set; }
    }
    class Employee
    {
        public int Salary { get; set; }
        public string Name { get; set; }
        public DateTime HiringDate { get; set; }    
        public event EventHandler<SalaryEventArgs> CompletedOneYear;

        public Employee( string name, int salary, DateTime hiringDate)
        {
            Salary = salary;
            Name = name;
            HiringDate = hiringDate;
        }
        public void ApplyRaise(int newSalary)
        {
            var updatedSalary = Salary + newSalary;
            if (DateTime.Now.Date > HiringDate)
            {
                CompletedOneYear?.Invoke(this, new SalaryEventArgs{NewSalary = updatedSalary});
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var emp = new Employee("Ahmed", 1000, new DateTime(2019,1,1));
            emp.CompletedOneYear += ApplyAnnualRaise;
            emp.ApplyRaise(100);
            emp.CompletedOneYear -= ApplyAnnualRaise;
            emp.ApplyRaise(500);
        }

        private static void ApplyAnnualRaise(object sender, SalaryEventArgs e)
        {
            Employee emp = sender as Employee;
            Debug.WriteLine($"{emp.Name}'s salary has been updated from {emp.Salary} to {e.NewSalary}");
        }
    }
}
