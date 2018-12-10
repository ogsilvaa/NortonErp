//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NortonMvc.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Ordene
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ordene()
        {
            this.FacturasOrdenes = new HashSet<FacturasOrdene>();
            this.OrdenesDetalles = new HashSet<OrdenesDetalle>();
        }
    
        public System.Guid OrdenId { get; set; }
        public string OrdenCodigo { get; set; }
        public string OrdenTipo { get; set; }
        public Nullable<System.DateTime> OrdenFecha { get; set; }
        public Nullable<System.Guid> OrdenProveedor { get; set; }
        public Nullable<decimal> OrdenSubtotal { get; set; }
        public Nullable<decimal> OrdenIgv { get; set; }
        public Nullable<decimal> OrdenTotal { get; set; }
        public Nullable<System.DateTime> OrdenPlazoEntrega { get; set; }
        public string OrdenFormaPago { get; set; }
        public Nullable<System.Guid> OrdenContactoInterno { get; set; }
        public string OrdenLugarEntrega { get; set; }
        public string OrdenEstado { get; set; }
        public string OrdenObservacion { get; set; }
        public string OrdenMotivoRechazo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FacturasOrdene> FacturasOrdenes { get; set; }
        public virtual Proveedore Proveedore { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrdenesDetalle> OrdenesDetalles { get; set; }
    }
}
