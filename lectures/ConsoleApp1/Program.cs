using ConsoleApp1.Entities;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee(600);
            Console.WriteLine($"{employee.Salory}");
            //employee.Salary = 300;

            Moto moto = new Moto();
            Moto moto1 = new Moto("Hoda", 123_023);
            moto.VinNumber = 2000;
            moto.CleanMoto(ref moto);
        }
    }
}
