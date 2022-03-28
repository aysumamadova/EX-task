using System;
using System.Collections.Generic;
using System.Text;

namespace Ex_tast.Models
{
   public class Employee:IPerson
    {
        private static int _id =0;
        public double Salary  { get; set; }
        public int Id { get; }
        public string Name { get; set; }
        public int Age { get; set; }
        private Employee()
        {
            ++_id;
            Id = _id;
        }
        public Employee(string name, int age, double salary):this()
        {
            Name = name;
            Age = age;
            Salary = salary;

        }
        public string ShowInfo()
        {
            return $"Id: {Id} Name:{Name} Name: {Name} Age: {Age} Salary: {Salary}";
        }
        public override string ToString()
        {
            return ShowInfo();
        }
    }
}
