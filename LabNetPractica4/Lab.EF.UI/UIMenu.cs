using Lab.EF.Entities;
using Lab.EF.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Lab.EF.Logic.CustomerLogic;

namespace Lab.EF.UI
{
    public class UIMenu
    {
        protected readonly CustomerLogic customerLogic;
        protected readonly ProductsLogic productsLogic;

        public UIMenu()
        {
            customerLogic = new CustomerLogic();
            productsLogic = new ProductsLogic();
        }

        public void Start()
        {
            bool exit = false;

            while (!exit)
            {
                Console.Clear();
                Console.WriteLine("Menu:");
                Console.WriteLine("Escribe el número de query que quieras hacer.");
                Console.WriteLine("1. Query para devolver objeto customer");
                Console.WriteLine("2. Query para devolver todos los productos sin stock");
                Console.WriteLine("3. Query para devolver todos los productos que tienen stock y que cuestan más de 3 por\r\nunidad");
                Console.WriteLine("4. Query para devolver todos los customers de la Región WA");
                Console.WriteLine("5. Query para devolver el primer elemento o nulo de una lista de productos donde el ID de\r\nproducto sea igual a 789");
                Console.WriteLine("6. Query para devolver los nombre de los Customers. Mostrarlos en Mayuscula y en\r\nMinuscula.");
                Console.WriteLine("7. Query para devolver Join entre Customers y Orders donde los customers sean de la \r\nRegión WA y la fecha de orden sea mayor a 1/1/1997.");
                Console.WriteLine("8. Query para devolver los primeros 3 Customers de la  Región WA");
                Console.WriteLine("9. Query para devolver lista de productos ordenados por nombre");
                Console.WriteLine("10. Query para devolver lista de productos ordenados por unit in stock de mayor a menor.");
                Console.WriteLine("11. Query para devolver las distintas categorías asociadas a los productos");
                Console.WriteLine("12. Query para devolver el primer elemento de una lista de productos");
                Console.WriteLine("13. Exit");
                Console.Write("Elige una opción: ");
                string userChoice = Console.ReadLine();
                switch (userChoice)
                {
                    case "1":
                        Console.WriteLine("Inserta el ID del Customer");
                        var customerID = Console.ReadLine();
                        var customerSelected = customerLogic.GetCustomer(customerID);
                        if (customerSelected == null) Console.WriteLine("No existe ese Customer");
                        Console.ReadLine();
                        break;

                    case "2":
                        foreach (Product product in productsLogic.GetNoStockProducts())
                        {
                            Console.WriteLine(product.ProductName);
                        }
                        Console.ReadLine();
                        break;

                    case "3":
                        foreach (Product product in productsLogic.GetStockProducts())
                        {
                            Console.WriteLine(product.ProductName);
                        }
                        Console.ReadLine();
                        break;

                    case "4":
                        foreach (Customer customer in customerLogic.GetWACustomers())
                        {
                            Console.WriteLine(customer.ContactName);
                        }
                        Console.ReadLine();
                        break;

                    case "5":
                        var product789 = productsLogic.GetProductById(789);
                        if (product789 == null) Console.WriteLine("No existe el producto con el ID 789");
                        Console.ReadLine();
                        break;

                    case "6":
                        foreach (Object customer in customerLogic.GetCustomerNames())
                        {
                            Console.WriteLine(customer);
                        }
                        Console.ReadLine();
                        break;

                    case "7":
                        foreach (Object customer in customerLogic.GetCustomersWithOrders())
                        {
                            Console.WriteLine(customer);
                        }
                        Console.ReadLine();
                        break;

                    case "8":
                        foreach (Customer customer in customerLogic.GetFirstThreeWACustomers())
                        {
                            Console.WriteLine(customer.ContactName + " " + customer.Region);
                        }
                        Console.ReadLine();
                        break;

                    case "9":
                        foreach (Product product in productsLogic.GetProductsOrderedByName())
                        {
                            Console.WriteLine(product.ProductName);
                        }
                        Console.ReadLine();
                        break;

                    case "10":
                        foreach (Product product in productsLogic.GetProductsOrderedByStock())
                        {
                            Console.WriteLine(product.ProductName + " " + product.UnitsInStock);
                        }
                        Console.ReadLine();
                        break;

                    case "11":
                        foreach (Object productWithCategory in productsLogic.GetProductsWithCategories())
                        {
                            Console.WriteLine(productWithCategory);
                        }
                        Console.ReadLine();
                        break;

                    case "12":
                        Console.WriteLine(productsLogic.GetFirstProduct().ProductName);
                        Console.ReadLine();
                        break;

                    case "13":
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("No has elegido una opción válida. Intenta de nuevo.");
                        Console.ReadLine();
                        break;
                }
            }
        }
    }

}
