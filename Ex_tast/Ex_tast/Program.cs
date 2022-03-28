using System;
using Ex_tast.Models;

namespace Ex_tast
{
    class Program
    {
        static void Main(string[] args)
        {
            Department d = new Department("Aysu", 2);
            Employee e = new Employee("ayse",3,22);
            Employee e1 = new Employee("ayse", 3, 22);
            d.AddEmployee(e);
            //Console.WriteLine(e.ShowInfo());
            //Console.WriteLine(e1.ShowInfo());
            Console.WriteLine(d[0].ToString());
        }
    }
}
