using System;
using BlogSystem.Data;
using System.Linq;
using System.Web.Mvc;
using BlogSystem.Model;

namespace BlogSystem.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            BlogSystemDbContext context = new BlogSystemDbContext();
            //var test = context.Posts.Count();

            //var user = new User();

            //var post = new Post();
            //post.Name = "opit";
            //post.Content = "TWERTWETEW trweT tREWt RE tre TREt RET re tRe";
            //post.DateCreated = new DateTime(2002, 11, 10);
            //post.User = user;

            //context.Posts.Add(post);
            //context.SaveChanges();

            return View(context);
        }
    }
}