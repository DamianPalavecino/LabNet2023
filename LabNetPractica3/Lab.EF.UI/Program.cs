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
            Console.WriteLine("Empleados:");
            foreach (Employee employee in employeeLogic.GetAll())
            {
                Console.WriteLine($"{employee.EmployeeID} -- {employee.FirstName} {employee.LastName} -- {employee.Title}");
            }

            CustomerLogic customerLogic = new CustomerLogic();
            Console.WriteLine("Clientes:");
            foreach (Customer customer in customerLogic.GetAll())
            {
                Console.WriteLine($"{customer.CustomerID} -- {customer.ContactName} -- {customer.CompanyName}");
            }

            Console.WriteLine("Actualizar Cliente");
            Console.WriteLine("Escribe el ID del Cliente");
            var idCliente = Console.ReadLine();
            Console.WriteLine("Escribe el nombre de la nueva Compañia");
            var nombreCompania = Console.ReadLine();
            customerLogic.Update(new Customer
            {
                CustomerID = idCliente,
                CompanyName = nombreCompania
            });

            Console.WriteLine("Agregar Cliente");
            Console.WriteLine("Escribe el ID del Nuevo Cliente");
            var idCliente2 = Console.ReadLine();
            Console.WriteLine("Escribe el nombre de su Compañia");
            var nombreCompania2 = Console.ReadLine();
            customerLogic.Add(new Customer
            {
                CustomerID = idCliente2,
                CompanyName = nombreCompania2
            });

            Console.WriteLine("Borrar Cliente");
            Console.WriteLine("Escribe el ID del Cliente que quieres borrar");
            var idABorrar = Console.ReadLine();
            customerLogic.Remove(idABorrar);
            Console.ReadLine();
        }
    }
}
