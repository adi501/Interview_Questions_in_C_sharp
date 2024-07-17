using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Injection_Constructor_Net_Framework
{
    public class ContractEmployee:IEmployee
    {
        public void GetName()
        {
            Console.WriteLine("ContractEmployee-GetName");
        }

        public void GetSalary()
        {
            Console.WriteLine("ContractEmployee-GetSalary");
        }
    }
}
