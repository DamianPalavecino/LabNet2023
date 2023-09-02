using Lab.EF.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.EF.Logic
{
    public class EmployeeLogic : BaseLogic
    {
        public List<Employee> GetAll()
        {
            return context.Employees.ToList();
        }
    }
}
