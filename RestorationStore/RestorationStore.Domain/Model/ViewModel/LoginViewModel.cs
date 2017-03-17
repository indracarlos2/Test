using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Web.Mvc;
namespace RestorationStore.Domain.Model.ViewModel {
    public class LoginViewModel {
        public string Usuario { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
         [HiddenInput(DisplayValue = false)]
        public string Role { get; set; }
    }
}
 //using System.ComponentModel.DataAnnotations;
 //   using RestorationStore.Domain.Model.ViewModel;
 //   [MetadataType(typeof(LoginViewModel))]