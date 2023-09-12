using System.ComponentModel.DataAnnotations;

namespace Lab.EF.MVC.Models
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