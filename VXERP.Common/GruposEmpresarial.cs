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
    
    public partial class GruposEmpresarial
    {
        public GruposEmpresarial()
        {
            this.Companias = new HashSet<Companias>();
            this.Divisiones = new HashSet<Divisiones>();
            this.Sucursales = new HashSet<Sucursales>();
        }
    
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public string DescripcionCorta { get; set; }
        public string Responsable { get; set; }
        public string CedulaResponsable { get; set; }
        public bool Estado { get; set; }
        public System.DateTime FechaCreacion { get; set; }
        public Nullable<System.DateTime> FechaActualizacion { get; set; }
        public Nullable<int> IdUsuario { get; set; }
    
        public virtual ICollection<Companias> Companias { get; set; }
        public virtual ICollection<Divisiones> Divisiones { get; set; }
        public virtual Usuarios Usuarios { get; set; }
        public virtual ICollection<Sucursales> Sucursales { get; set; }
    }
}