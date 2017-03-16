using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Web.Mvc;
namespace RestorationStore.Domain.Model.ViewModel {
    public class ContactViewModel {
        [HiddenInput(DisplayValue = false)]
        public int Id_Request { get; set; }

        [DisplayName("Name")]
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Please, introduce the name")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "Please, no more than 50 characters")]
        public string Name { get; set; }

        [DisplayName("Email")]
        [Required(ErrorMessage = "Please, introduce the email")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Please enter a valid email address")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "Please, no more than 50 characters")]
        public string Email { get; set; }

        [DataType(DataType.PhoneNumber)]
        [DisplayName("Phone")]
        [StringLength(12, MinimumLength = 0, ErrorMessage = "Please, no more than 12 characters")]
        public string Phone { get; set; }

        [DisplayName("Address")]
        [DataType(DataType.MultilineText)]
        [StringLength(50, MinimumLength = 0, ErrorMessage = "Please, no more than 50 characters")]
        public string Address { get; set; }
    }
}
 //using System.ComponentModel.DataAnnotations;
 //   using RestorationStore.Domain.Model.ViewModel;
 //   [MetadataType(typeof(ContactViewModel))]