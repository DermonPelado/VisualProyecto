//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BDDModels
{
    using System;
    using System.Collections.Generic;
    
    public partial class Producto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Producto()
        {
            this.Comentario = new HashSet<Comentario>();
        }
    
        public int IDProducto { get; set; }
        public Nullable<int> IDVendedor { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public Nullable<int> IDAnio { get; set; }
        public Nullable<int> IDMateria { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
        public string Foto { get; set; }
        public Nullable<int> Precio { get; set; }
    
        public virtual Anio Anio { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Comentario> Comentario { get; set; }
        public virtual Materias Materias { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
