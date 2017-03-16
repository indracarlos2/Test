using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Web.Mvc;
namespace RestorationStore.Domain.Model.ViewModel {
    public class RequestPendingViewModel {
        [DisplayName("Title of request")]
        [Required(ErrorMessage = "Please, introduce the title of request")]
        [StringLength(30, MinimumLength = 0, ErrorMessage = "Please, no more than 30 characters")]
        public string TITLEMESSAGE { get; set; }

        [DisplayName("Estatus")]
        public string ESTATUS { get; set; }
        
        [HiddenInput(DisplayValue = false)]
        public byte[] INITIALIMAGE { get; set; }

        [DisplayName("Name")]
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Please, introduce the name")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "Please, no more than 50 characters")]
        public string NAME { get; set; }

        [DisplayName("Email")]
        [Required(ErrorMessage = "Please, introduce the email")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Please enter a valid email address")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "Please, no more than 50 characters")]
        public string EMAIL { get; set; }
     
        [DataType(DataType.PhoneNumber)]
        [DisplayName("Phone")]
        [StringLength(12, MinimumLength = 0, ErrorMessage = "Please, no more than 12 characters")]
        public string PHONE { get; set; }

        [DisplayName("Address")]
        [DataType(DataType.MultilineText)]
        [StringLength(50, MinimumLength = 0, ErrorMessage = "Please, no more than 50 characters")]
        public string ADDRESS { get; set; }
        
        [DisplayName("Initial date")]
        [HiddenInput(DisplayValue = true)]
        public System.DateTime INITIALDATE { get; set; }

        [DisplayName("Description")]
        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "Please, introduce the description")]
        [StringLength(500, MinimumLength = 0, ErrorMessage = "Please, no more than 500 characters")]
        public string DESCRIPTION { get; set; }
        
        [HiddenInput(DisplayValue = false)]
        public int ID { get; set; }

        [HiddenInput(DisplayValue = false)]
        public string IMAGEMIMETYPE { get; set; }
    }
}
//using System.ComponentModel.DataAnnotations;
//    using RestorationStore.Domain.Model.ViewModel;

//     [MetadataType(typeof(RequestPendingViewModel))]