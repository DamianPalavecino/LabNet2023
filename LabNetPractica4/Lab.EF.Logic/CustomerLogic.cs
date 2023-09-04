using Lab.EF.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
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
    }
}
