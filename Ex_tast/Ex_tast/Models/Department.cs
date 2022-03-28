using System;
using System.Collections.Generic;
using System.Text;
using Ex_tast.CapasityEX;

namespace Ex_tast.Models
{
   public class Department
    {
        public string Name { get; set; }
        public double EmployeeLimit { get; set; }
        private Employee[] _emp=new Employee[0] ;
        public Employee this[int index]
        {
            get { return _emp[index]; }
            set {_emp[index]=value; }
        }

        public Department(string name,double employeeLimit)
        {
            Name = name;
            EmployeeLimit = employeeLimit;
        }

        public void AddEmployee(Employee employee)
        {
            if (_emp.Length < EmployeeLimit)
            {
                Array.Resize(ref _emp, _emp.Length + 1);
                _emp[_emp.Length - 1] = employee;
            }
            else
            {
                throw new CapacityLimitException("limit asildi");
            }
        }
    }
}
