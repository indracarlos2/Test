using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestorationStore.Domain.Model.ViewModel {
    public class CommentaryViewModel {
        public int Id { get; set; }
        public string Author { get; set; }
        public string Message { get; set; }
        public int Id_Response { get; set; }
    }
}
  //using System.ComponentModel.DataAnnotations;
  //  using RestorationStore.Domain.Model.ViewModel;
  //  [MetadataType(typeof(CommentaryViewModel))]