//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CarcenterWeb.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class PERSONAS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PERSONAS()
        {
            this.PERSONA_VEHICULO = new HashSet<PERSONA_VEHICULO>();
        }
    
        public decimal IDENTIFICACION { get; set; }
        public string NOMBRES { get; set; }
        public decimal TELEFONO { get; set; }
        public string DIRECCION { get; set; }
        public string CORREO { get; set; }
        public string ESPECIALIDAD { get; set; }
        public string TIPO_PERSONA { get; set; }
        public string CONTRASENA { get; set; }
        public string ESTADO_PERSONA { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PERSONA_VEHICULO> PERSONA_VEHICULO { get; set; }
    }
}
