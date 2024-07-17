using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Injection_Constructor_Net_Framework
{
    public class PermanentEmployee : IEmployee
    {
        public void GetName()
        {
            Console.WriteLine("PermanentEmployee-GetName");
        }

        public void GetSalary()
        {
            Console.WriteLine("PermanentEmployee-GetSalary");
        }
    }
}
