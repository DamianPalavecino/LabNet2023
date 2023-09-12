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
        public void Add(Employee employee)
        {
            context.Employees.Add(employee);
            context.SaveChanges();
        }

        public List<Employee> GetAll()
        {
            return context.Employees.ToList();
        }

        public void Remove(int id)
        {
            var employeeAEliminar = context.Employees.Find(id);
            context.Employees.Remove(employeeAEliminar);
            context.SaveChanges();
        }

        public void Update(Employee employee)
        {
            var employeeParaActualizar = context.Employees.Find(employee.EmployeeID);
            employeeParaActualizar.Title = employee.Title;
            context.SaveChanges();
        }
    }
}
