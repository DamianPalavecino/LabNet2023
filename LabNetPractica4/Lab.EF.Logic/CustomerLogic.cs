using Lab.EF.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Lab.EF.Logic
{
    public class CustomerLogic : BaseLogic, ABMLogic<Customer>
    {
        public void Add(Customer nombre)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Customer nombre)
        {
            throw new NotImplementedException();
        }

        public Customer GetCustomer(string customerId)
        {
            var customer = (from c in context.Customers
                            where c.CustomerID == customerId
                            select c).FirstOrDefault();
            return customer;

        }

        public List<Customer> GetWACustomers()
        {
            var customersInWA = (from c in context.Customers
                                 where c.Region == "WA"
                                 select c).ToList();
            return customersInWA;
        }

        public List<object> GetCustomerNames()
        {
            var customerNames = (from customer in context.Customers
                                 select new
                                 {
                                     Uppercase = customer.ContactName.ToUpper(),
                                     Lowercase = customer.ContactName.ToLower(),
                                 }).ToList<object>();

            return customerNames;
        }

        public List<object> GetCustomersWithOrders()
        {
            var customersWithOrders = (
                                        from Customers in context.Customers
                                        join Orders in context.Orders on Customers.CustomerID equals Orders.CustomerID
                                        where Customers.Region == "WA" && Orders.OrderDate > new DateTime(1997, 1, 1)
                                        select new
                                        {
                                            customerName = Customers.ContactName,
                                            region = Customers.Region,
                                            orderDate = Orders.OrderDate
                                        }
                                        ).Distinct().ToList<object>();
            return customersWithOrders;
        }

        public List<Customer> GetFirstThreeWACustomers()
        {
            return context.Customers.Where(c => c.Region == "WA").Take(3).ToList();
        }

        public class CustomersWithOrderCount
        {
            public string CustomerName;
            public int OrderCount;
        }
    }
}
