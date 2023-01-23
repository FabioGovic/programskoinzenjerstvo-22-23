using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M.Modeli
{
    public class EmployeeBuil
    {
        private Employee employee;

        public EmployeeBuil(string name)
        {
            employee = new Employee(name);
        }
        public Employee Build()
        {
            return employee;
        }

        public EmployeeBuil SetSalary(double salary)
        {
            employee.Salary = salary;
            return this;
        }

        
    }
}
