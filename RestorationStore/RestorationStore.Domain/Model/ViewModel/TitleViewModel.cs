using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Web.Mvc;
namespace RestorationStore.Domain.Model.ViewModel {
    public class TitleViewModel {
        [HiddenInput(DisplayValue = false)]
        public int Id_Request { get; set; }

        [DisplayName("Title of request")]
        [Required(ErrorMessage = "Please, introduce the title of request")]
        [StringLength(30, MinimumLength = 0, ErrorMessage = "Please, no more than 30 characters")]
        public string TitleMessage { get; set; }
    }
}
