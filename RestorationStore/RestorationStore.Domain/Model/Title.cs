//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RestorationStore.Domain.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Title
    {
        public int Id_Request { get; set; }
        public string TitleMessage { get; set; }
    
        public virtual Request Request { get; set; }
    }
}
