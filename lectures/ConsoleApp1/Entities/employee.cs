using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Entities
{
    class Employee
    {
        private string _name;
        private int _salary;

        public int Salory
        {
            get { return _salary; }
            private set
            {
                if (value >= 300)
                {
                    Console.WriteLine("ok");
                }
                _salary = value;
            }
        }

        public Employee()
        {
        }

        public  Employee(int employeeSalary)
        {
            Salory = employeeSalary;
        }

    }
}
