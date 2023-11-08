using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalAdvancedC_.Delegates
{
    internal class Report
    {
        public delegate bool checkSalary(Employee employee);
        public void ProccessEmployee(Employee[] employees,checkSalary checkSalary)
        {
            foreach( Employee employee in employees )
            {
                if(checkSalary(employee))//Invoke
                {
                    Console.WriteLine($"{employee.Name} || {employee.Salary}");
                    Console.WriteLine("\n");
                }
            }
            
        }
      
    }
}
