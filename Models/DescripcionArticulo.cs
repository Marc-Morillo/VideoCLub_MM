//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MiVideoClub.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class DescripcionArticulo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DescripcionArticulo()
        {
            this.RentaDevolucion = new HashSet<RentaDevolucion>();
        }
    
        public int ID { get; set; }
        public string Titulo { get; set; }
        public Nullable<int> idElenco { get; set; }
        public Nullable<int> idTipoArticulo { get; set; }
        public Nullable<int> idIdioma { get; set; }
        public Nullable<int> idGenero { get; set; }
        public Nullable<int> RentaporDia { get; set; }
        public Nullable<int> DiasRenta { get; set; }
        public Nullable<int> MontoEntrega { get; set; }
        public Nullable<int> idEstado { get; set; }
    
        public virtual C_Elenco C_Elenco { get; set; }
        public virtual C_Estado C_Estado { get; set; }
        public virtual C_Generos C_Generos { get; set; }
        public virtual C_Idiomas C_Idiomas { get; set; }
        public virtual C_TipoArticulo C_TipoArticulo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RentaDevolucion> RentaDevolucion { get; set; }
    }
}
