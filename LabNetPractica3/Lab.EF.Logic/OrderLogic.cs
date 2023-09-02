using Lab.EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.EF.Logic
{
    public class OrderLogic : BaseLogic, ABMLogic<Order>
    {
        public void Add(Order order)
        {
            context.Orders.Add(order);
            context.SaveChanges();
        }

        public List<Order> GetAll()
        {
            return context.Orders.ToList();
        }

        public void Remove(string id)
        {
            var orderParaQuitar = context.Orders.Find(id);
            context.Orders.Remove(orderParaQuitar);
            context.SaveChanges();
        }

        public void Update(Order order)
        {
            var orderParaActualizar = context.Orders.Find(order.OrderID);
            orderParaActualizar.ShipName = order.ShipName;
            context.SaveChanges();
        }
    }
}
