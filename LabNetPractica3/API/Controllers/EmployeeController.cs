using System.Collections.Generic;
using System.Web.Http;
using Lab.EF.Logic;
using Lab.EF.Entities;
using API.Models;
using System.Linq;
using System;
using System.Net;
using System.Web.UI.WebControls;

namespace API.Controllers
{
    public class EmployeeController : ApiController
    {

        EmployeeLogic employeeLogic = new EmployeeLogic();

        // GET api/<controller>
        public IEnumerable<EmployeeView> Get()
        {
            try
            {
                List<Employee> employees = employeeLogic.GetAll();
                List<EmployeeView> employeeView = employees.Select(e => new EmployeeView
                {
                    Id = e.EmployeeID,
                    Nombre = e.FirstName,
                    Apellido = e.LastName,
                    Titulo = e.Title
                }).ToList(); ;

                return employeeView;
            } catch (Exception ex)
            {
                throw ex;
            }
        }

        // GET api/<controller>/5
        public EmployeeView Get(int id)
        {
            try
            {
                Employee employee = employeeLogic.GetById(id) ?? throw new HttpResponseException(HttpStatusCode.NotFound);
                EmployeeView employeeView = new EmployeeView
                {
                    Id = employee.EmployeeID,
                    Nombre = employee.FirstName,
                    Apellido = employee.LastName,
                    Titulo = employee.Title
                };

                return employeeView;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // POST api/<controller>
        public void Post([FromBody] EmployeeView employeeView)
        {
            try
            {
                List<Employee> employees = employeeLogic.GetAll();
                int newEmployeeId = employees.Max(e => e.EmployeeID) + 1;
                Employee employee = new Employee
                {
                    EmployeeID = newEmployeeId,
                    FirstName = employeeView.Nombre,
                    LastName = employeeView.Apellido,
                    Title = employeeView.Titulo
                };

                employeeLogic.Add(employee);
            } catch (Exception ex)
            {
                throw ex;
            }
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody] EmployeeView employeeView)
        {
            try
            {
                Employee employee = employeeLogic.GetById(id);
                employee.FirstName = employeeView.Nombre;
                employee.LastName = employeeView.Apellido;
                employee.Title = employeeView.Titulo;

                employeeLogic.Update(employee);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
            try
            {
                employeeLogic.Remove(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}