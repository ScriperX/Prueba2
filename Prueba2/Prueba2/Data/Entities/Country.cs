using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Prueba2.Data.Entities
{
    public class Country
    {
        public int Id { get; set; }

        [Display(Name = "País")]
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener máximo {1} caractéres.")]
        [Required(ErrorMessage = " El campo {0} es obligatorio." )]
        public string Name { get; set; }

        //Como hacer una relación de State (N:1) Country - la relación se debe hacer en ambas entidades para cumplir con normalización
        // y poder filtrar desde States
        public ICollection<State> States { get; set; }

        //Propiedad de lectura (Con un operador ternario "if")
        [Display(Name = "Departamentos")]
        public int StatesNumber => States == null ? 0 : States.Count;

    }
}
