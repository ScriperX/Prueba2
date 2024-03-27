using System.ComponentModel.DataAnnotations;

namespace Prueba2.Data.Entities
{
    public class City
    {
        public int Id { get; set; }

        [Display(Name = "Ciudad")]
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener máximo {1} caractéres.")]
        [Required(ErrorMessage = " El campo {0} es obligatorio.")]
        public string Name { get; set; }

        //Relación State (N:1) City
        public State State { get; set; }


    }
}
