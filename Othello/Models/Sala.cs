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
    
    public partial class Sala
    {
        public int ID_Sala { get; set; }
        public Nullable<int> id_partida { get; set; }
        public Nullable<int> id_usuario { get; set; }
        public Nullable<int> CantMovJ1 { get; set; }
        public Nullable<int> CantMovJ2 { get; set; }
    
        public virtual Partida Partida { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
