using Lab.EF.MVC.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Web.Mvc;

namespace Lab.EF.MVC.Controllers
{
    public class TodosController : Controller
    {
        public ActionResult Index()
        {
            try
            {
                HttpClient httpClient = new HttpClient();
                httpClient.BaseAddress = new Uri("https://jsonplaceholder.typicode.com/");
                var response = httpClient.GetAsync("todos").Result;

                if (response.IsSuccessStatusCode)
                {
                    var result = response.Content.ReadAsStringAsync().Result;
                    List<TodosView> todosList = JsonConvert.DeserializeObject<List<TodosView>>(result);
                    return View("Index", todosList);
                }
                else
                {
                    return View("Error");
                }

            } catch (Exception) {
                throw;
            }
        }
    }
}