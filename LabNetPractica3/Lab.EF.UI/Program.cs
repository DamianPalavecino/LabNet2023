using Lab.EF.Entities;
using Lab.EF.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.EF.UI
{
    internal class Program
    {
        static void Main(string[] args)
        {

            EmployeeLogic employeeLogic = new EmployeeLogic();

            foreach (Employee employee in employeeLogic.GetAll())
            {
                Console.WriteLine(employee.FirstName);
            }

            Console.ReadLine();
        }
    }
}
