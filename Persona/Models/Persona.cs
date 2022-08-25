using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Persona.Models
{
    public class Persona
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public long Id { get; set; }
        [Required(ErrorMessage = "El DUI es requerido")]
        [StringLength(10)]
        [RegularExpression(@"^[0-9]{8}-[0-9]{1}$", ErrorMessage = "Formato correcto de DUI: XXXXXXXX-X")]
        public string DUI { get; set; }
        [Required(ErrorMessage = "El Nombre es requerido")]
        [StringLength(100)]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "El Apellido es requerido")]
        [StringLength(100)]
        public string Apellido { get; set; }
        [Required(ErrorMessage = "La fecha de nacimiento es requerida")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime FechaNacimiento { get; set; }
        public string Direccion { get; set; }
        [Required(ErrorMessage = "El correo electrónico es requerido")]
        [EmailAddress(ErrorMessage = "Debe ingresar un correo electrónico válido")]
        public string Email { get; set; }
    }
}