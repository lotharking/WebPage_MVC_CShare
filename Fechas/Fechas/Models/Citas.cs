//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Fechas.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class citas
    {
        public int Num { get; set; }
        public string Formato { get; set; }
        public int Revision { get; set; }
        public string Cuando_usar { get; set; }
        public string Detalles { get; set; }
    
        public virtual detalles detalles1 { get; set; }
    }
}