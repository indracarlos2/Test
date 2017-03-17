using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using RestorationStore.Domain;
using RestorationStore.Domain.Model;
using RestorationStore.Domain.Model.ViewModel;
namespace RestorationStore.Controllers
{
    public class CommentaryController : ApiController{
        Repository<Commentary> commentaryContext = new Repository<Commentary>();

        [HttpGet]
        public IEnumerable<CommentaryViewModel> GetCommentaries(int id) {
            System.Linq.Expressions.Expression<Func<Commentary, bool>> expr =
                x => x.Id_Response == id;
            IEnumerable<Commentary> commentaries = commentaryContext.Find(expr);
            List<CommentaryViewModel> list = new List<CommentaryViewModel>();
            foreach(Commentary comm in commentaries) {
                CommentaryViewModel commentaryVM = new CommentaryViewModel();
                commentaryVM.Author = comm.Author;
                commentaryVM.Message = comm.Message;
                list.Add(commentaryVM);
            }
            return list.AsEnumerable(); 
        }

        [HttpPost]
        public bool CreateCommentary(CommentaryViewModel comm) {
          if(comm!=null){
              Commentary commentary = new Commentary();
              commentary.Author = comm.Author;
              if(comm.Author==null||comm.Author.Trim().Equals("")){
                  commentary.Author = "Anonymous";
              }
              commentary.Message = comm.Message;
              commentary.Id_Response = comm.Id_Response;
              commentaryContext.Add(commentary);
              commentaryContext.Save();
              return true;
          }
          return false;
        }

    }
}
