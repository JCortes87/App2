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
    
    public partial class PERSONA_VEHICULO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PERSONA_VEHICULO()
        {
            this.CITAS = new HashSet<CITAS>();
        }
    
        public decimal ID_PERSONA_VEHICULO { get; set; }
        public string PLACA { get; set; }
        public decimal IDENTIFICACION { get; set; }
        public string ESTADO_PROP { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CITAS> CITAS { get; set; }
        public virtual PERSONAS PERSONAS { get; set; }
        public virtual VEHICULOS VEHICULOS { get; set; }
    }
}
