using System.Collections;
using System.Collections.Generic;
using System.Linq;
using BlogSystem.Data;
using System.Web.Mvc;
using BlogSystem.Model;
using BlogSystem.Models;

namespace BlogSystem.Controllers
{
    public class PostController : BaseController
    {
        [HttpGet]
        public ActionResult Index()
        {
            //BlogSystemDbContext context = new BlogSystemDbContext();
            ICollection<CommentViewModel> comments = Context.Comments.Select(c => new CommentViewModel()
            {
                Text = c.Text,
                Author = c.Author,
            }).ToList();

            ICollection<PostViewModel> posts = Context.Posts.Select(p => new PostViewModel()
            {
                Name = p.Name,
                Content = p.Content,
                DateCreated = p.DateCreated,
                UserName = p.User.UserName,
                Id = p.Id,
                //Comments = comments
            }
                ).ToList();
            //var user = new User();

            //var post = new Post();
            //post.Name = "opit";
            //post.Content = "TWERTWETEW trweT tREWt RE tre TREt RET re tRe";
            //post.DateCreated = new DateTime(2002, 11, 10);
            ////post.User = user;

            //context.Posts.Add(post);
            //context.SaveChanges();

            return View(posts);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(PostViewModel postViewModel)
        {
            var user = Context.Users.FirstOrDefault(u => u.Email == HttpContext.User.Identity.Name);

            var post = new Post()
            {
                Id = postViewModel.Id,
                Name = postViewModel.Name,
                Content = postViewModel.Content,
                DateCreated = postViewModel.DateCreated,
                User = user
            };

            Context.Posts.Add(post);
            Context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}