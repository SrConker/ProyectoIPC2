//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Othello.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tablero
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tablero()
        {
            this.Partida = new HashSet<Partida>();
        }
    
        public int ID_Tablero { get; set; }
        public Nullable<int> id_ficha { get; set; }
        public Nullable<int> id_marcador { get; set; }
    
        public virtual Ficha Ficha { get; set; }
        public virtual Marcador Marcador { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Partida> Partida { get; set; }
    }
}