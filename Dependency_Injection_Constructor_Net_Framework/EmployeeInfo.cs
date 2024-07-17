using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Injection_Constructor_Net_Framework
{
    // Class that depends on the IEmployee
    public class EmployeeInfo
    {
        private readonly IEmployee _employee;
        // Constructor injection
        public EmployeeInfo(IEmployee employee)
        {
            _employee = employee;
        }
        public void GetName()
        {
            _employee.GetName();
        }

        public void GetSalary()
        {
            _employee.GetSalary();
        }

    }
}
