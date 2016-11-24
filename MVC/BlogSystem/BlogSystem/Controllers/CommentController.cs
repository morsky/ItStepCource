using System;
using BlogSystem.Models;
using System.Web.Mvc;
using BlogSystem.Model;

namespace BlogSystem.Controllers
{
    public class CommentController : BaseController
    {
       [HttpGet]
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(CommentViewModel commentViewModel, int id)
        {
            //var user = Context.Users.FirstOrDefault(u => u.Email == HttpContext.User.Identity.Name);

            var comment = new Comment()
            {
                Text = commentViewModel.Text,
                Author = commentViewModel.Author,
                DateCreated = DateTime.Now,
                PostId = id
            };

            Context.Comments.Add(comment);
            Context.SaveChanges();

            return RedirectToAction("Index", "Post");
        }
    }
}