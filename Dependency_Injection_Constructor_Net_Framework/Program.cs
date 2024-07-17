using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Injection_Constructor_Net_Framework
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Create an instance of the dependency
            IEmployee contractEmployee = new ContractEmployee();

            // Create an instance of the class with the dependency injected
            EmployeeInfo contractEmployeeInfo = new EmployeeInfo(contractEmployee);

            // Use the class
            contractEmployeeInfo.GetName();
            contractEmployeeInfo.GetSalary();


            // Create an instance of the dependency
            IEmployee permanentEmployee = new PermanentEmployee();

            // Create an instance of the class with the dependency injected
            EmployeeInfo permanentEmployeeInfo = new EmployeeInfo(permanentEmployee);

            // Use the class
            permanentEmployeeInfo.GetName();
            permanentEmployeeInfo.GetSalary();

            Console.ReadLine();

        }
    }
}
