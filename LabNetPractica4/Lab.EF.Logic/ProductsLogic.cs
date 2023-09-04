﻿using Lab.EF.Data;
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
    public class ProductsLogic : BaseLogic, ABMLogic<Product>
    {
        public void Add(Product nombre)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return context.Products.ToList();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Product nombre)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetNoStockProducts()
        {
            var productsWithoutStock = (from p in context.Products
                                        where p.UnitsInStock == 0
                                        select p).ToList();
            return productsWithoutStock;
        }

        public List<Product> GetStockProducts()
        {
            var productsWithStock = (from p in context.Products
                                     where p.UnitsInStock > 0 && p.UnitPrice > 3
                                     select p).ToList();
            return productsWithStock;
        }

        public Product GetProductById(int id)
        {
            var product = (from p in context.Products
                                    where p.ProductID == id
                                    select p).FirstOrDefault();
            return product;
        }


    }
}
