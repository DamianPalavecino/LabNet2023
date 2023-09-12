using Lab.EF.Entities;
using Lab.EF.Logic;
using Lab.EF.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Lab.EF.MVC.Controllers
{
    public class EmployeeController : Controller
    {
        EmployeeLogic logic = new EmployeeLogic();
        // GET: Employee
        public ActionResult Index()
        {
            try
            {
            List<Employee> employees = logic.GetAll();
            List<EmployeeView> employeeView = employees.Select(e => new EmployeeView
            {
                Id = e.EmployeeID,
                Nombre = e.FirstName,
                Apellido = e.LastName,
                Titulo = e.Title
            }).ToList();

            return View(employeeView);
            } 
            catch (Exception)
            {
                return RedirectToAction("Index", "Error");
            }
        }

        public ActionResult Insert()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Insert(EmployeeView employeeView)
        {
            try
            {
                Employee newEmployee = new Employee
                {
                    EmployeeID = employeeView.Id,
                    FirstName = employeeView.Nombre,
                    LastName = employeeView.Apellido,
                    Title = employeeView.Titulo,
                };

                if (ModelState.IsValid)
                {
                    logic.Add(newEmployee);
                    return RedirectToAction("Index");
                }
                else
                {
                    return View(employeeView);
                }
            } catch (Exception)
            {
                return RedirectToAction("Index", "Error");
            }
        }

        public ActionResult Delete(int id)
        {
            try
            {
                logic.Remove(id);
                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                return RedirectToAction("Index", "Error");
            }
        }

        public ActionResult Edit(int id)
        {
            try
            {
                var entity = logic.GetAll().Where(e => e.EmployeeID == id).FirstOrDefault();
                EmployeeView model = new EmployeeView
                {
                    Id = entity.EmployeeID,
                    Nombre = entity.FirstName,
                    Apellido = entity.LastName,
                    Titulo = entity.Title,
                };

                return View(model);
            } catch (Exception)
            {
                return RedirectToAction("Index", "Error");
            }
        }

        [HttpPost]
        public ActionResult Edit(EmployeeView employeeView)
        {
            try
            {
                logic.Update(new Employee { EmployeeID = employeeView.Id, FirstName = employeeView.Nombre, LastName = employeeView.Apellido, Title = employeeView.Titulo });
                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                return RedirectToAction("Index", "Error");
            }
        }
    }
}