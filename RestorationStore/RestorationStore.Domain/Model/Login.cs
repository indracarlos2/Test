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
    [MetadataType(typeof(LoginViewModel))]
    public partial class Login
    {
        public string Usuario { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
    }
}
