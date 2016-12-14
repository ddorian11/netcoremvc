using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using netcoremvc.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace netcoremvc.Controllers
{
    public class ReviewController : Controller
    {
        
        public ActionResult Review(UserReview model)
        {
            var name = model.Name;
            var email = model.Email;
            var comment = model.Comment;

            /*ReviewTable table = new ReviewTable();
            table.Name = name;
            table.Email = email;
            table.Comment = comment;
            table.DateTime = DateTime.Now;*/

            return View();
        }


    }
}
