using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;//Esta libreria importa las anotacionas que se pueden llegar a hacer en un formulario

namespace CarcenterWeb.Models.DTOs
{
    public class DominiosDTO
    {
        [Required] // Lo que esta entre estas llaves son Data Annotations  
        [Display(Name ="Tipo Dominio")] //Va a mostrar lo que esta aqui cuando se llame
        [StringLength(50)]
        public String TipoDominio { get; set; }
        [Required]
        [Display(Name = "Id Dominio")]
        [StringLength(10)]
        public String IdDominio { get; set; }
        [Required]
        [Display(Name = "Valor Dominio")]
        [StringLength(50)]
        public String VlrDominio { get; set; }
    }
}