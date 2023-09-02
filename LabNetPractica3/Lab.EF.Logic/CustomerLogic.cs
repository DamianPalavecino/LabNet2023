using Lab.EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.EF.Logic
{
    public class CustomerLogic : BaseLogic, ABMLogic<Customer>
    {
        public void Add(Customer customer)
        {
            context.Customers.Add(customer);
            context.SaveChanges();
        }

        public List<Customer> GetAll()
        {
            return context.Customers.ToList();
        }

        public void Remove(string id)
        {
            var customerAQuitar = context.Customers.Find(id);
            context.Customers.Remove(customerAQuitar);
            context.SaveChanges();
        }

        public void Update(Customer customer)
        {
            var customerAActualizar = context.Customers.Find(customer.CustomerID);
            customerAActualizar.CompanyName = customer.CompanyName;
            context.SaveChanges();
        }
    }
}
