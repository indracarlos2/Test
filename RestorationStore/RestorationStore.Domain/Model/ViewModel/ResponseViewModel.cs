using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Web.Mvc;
namespace RestorationStore.Domain.Model.ViewModel {
    class ResponseViewModel {
        [HiddenInput(DisplayValue = false)]
        public int Id { get; set; }

        [HiddenInput(DisplayValue = false)]
        public int Id_Request { get; set; }
         
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Please, introduce the cost")]
        [RegularExpression(@"\d+(\.\d{1,2})?", ErrorMessage = "Invalid cost")]
        public decimal Cost { get; set; }

        [DisplayName("Description")]
        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "Please, introduce the description")]
        [StringLength(500, MinimumLength = 0, ErrorMessage = "Please, no more than 500 characters")]
        public string Description { get; set; }
        
        [HiddenInput(DisplayValue = true)]
        public System.DateTime FinalDate { get; set; }

        [HiddenInput(DisplayValue = false)]
        public byte[] FinalImage { get; set; }
    }
}
