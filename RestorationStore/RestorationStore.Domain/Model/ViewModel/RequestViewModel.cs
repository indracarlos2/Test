using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Web.Mvc;
namespace RestorationStore.Domain.Model.ViewModel {
    public class RequestViewModel {

        [HiddenInput(DisplayValue = false)]
        public int Id { get; set; }

        [DisplayName("Estatus")]
        public string Estatus { get; set; }

        [DisplayName("Description")]
        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "Please, introduce the description")]
        [StringLength(500, MinimumLength = 0, ErrorMessage = "Please, no more than 500 characters")]
        public string Description { get; set; }

        [DisplayName("Initial date")]
        [HiddenInput(DisplayValue = true)]
        public System.DateTime InitialDate { get; set; }
        
        [HiddenInput(DisplayValue = false)]
        public byte[] InitialImage { get; set; }
    }
}
