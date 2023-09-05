using Lab.EF.Data;
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

        public List<Product> GetProductsOrderedByName()
        {
            return context.Products.OrderBy(p => p.ProductName).ToList();
        }

        public List<Product> GetProductsOrderedByStock()
        {
            return context.Products.OrderByDescending(p => p.UnitsInStock).ToList();
        }

        public List<object> GetProductsWithCategories()
        {
            var productsWithCategories = context.Products.Join(
                                            context.Categories,
                                            product => product.CategoryID,
                                            category => category.CategoryID,
                                            (product, category) => new
                                            {
                                                category = category.CategoryName,
                                                product = product.ProductName,
                                            })
                                            .ToList<object>();

            return productsWithCategories;
        }

        public Product GetFirstProduct()
        {
            return context.Products.First();
        }

    }
}
