using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace API.Models
{
    public class EmployeeView
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo Apellido es obligatorio.")]
        public string Apellido { get; set; }

        [Required(ErrorMessage = "El campo Nombre es obligatorio.")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El campo Título es obligatorio.")]
        public string Titulo { get; set; }

    }
}

