using System.ComponentModel.DataAnnotations;

namespace Prueba2.Data.Entities
{
    public class State
    {
        public int Id { get; set; }

        [Display(Name = "Departamento")]
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener máximo {1} caractéres.")]
        [Required(ErrorMessage = " El campo {0} es obligatorio.")]
        public string Name { get; set; }

        //Como hacer una relación de Country (1:N) State
        public Country Country { get; set; }

        // R: State (1:N) Cities
        public ICollection<City> Cities { get; set; }

        //Reading prop
        [Display(Name = "Ciudades")]
        public int CitiesNumber => Cities == null ? 0 : Cities.Count;
    }
}
