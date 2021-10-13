using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SegundoParcial.Models
{
    public class Suerte
    {
        [Key] //llave primaria 
        public int SuerteId { get; set; } 
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0} es requerido")] //data anotation todos los campos son requeridos, no se permiten campos vacios o muestra mensaje de error
        public string Detalle { get; set; } //
        [Url]
        [StringLength(100, MinimumLength = 10, ErrorMessage = "La longitud de {0} debe estar entre {2} y {1}")]
        public string Imagen { get; set; }
    }
}
