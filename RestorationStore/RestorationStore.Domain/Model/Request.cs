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
    using System.ComponentModel.DataAnnotations;
    using RestorationStore.Domain.Model.ViewModel;
    [MetadataType(typeof(RequestViewModel))]
    public partial class Request
    {
        public Request()
        {
            this.Responses = new HashSet<Respons>();
        }
    
        public int Id { get; set; }
        public string Estatus { get; set; }
        public string Description { get; set; }
        public System.DateTime InitialDate { get; set; }
        public byte[] InitialImage { get; set; }
        public string ImageMimeType { get; set; }
    
        public virtual Title Title { get; set; }
        public virtual Contact Contact { get; set; }
        public virtual ICollection<Respons> Responses { get; set; }
    }
}
