//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VXERP.Common
{
    using System;
    using System.Collections.Generic;
    
    public partial class Paises
    {
        public Paises()
        {
            this.Provincias = new HashSet<Provincias>();
        }
    
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public string DescripcionCorta { get; set; }
        public int IdContinente { get; set; }
        public bool Estado { get; set; }
        public System.DateTime FechaCreacion { get; set; }
        public System.DateTime FechaActualizacion { get; set; }
        public Nullable<int> IdUsuario { get; set; }
    
        public virtual Continentes Continentes { get; set; }
        public virtual Usuarios Usuarios { get; set; }
        public virtual ICollection<Provincias> Provincias { get; set; }
    }
}