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
    
    public partial class Estado
    {
        public int IDEstado { get; set; }
        public string Estado1 { get; set; }
        public Nullable<int> IDComprador { get; set; }
    
        public virtual Usuario Usuario { get; set; }
    }
}
