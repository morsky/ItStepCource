using System.Collections.Generic;
using System.Linq;
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
            ICollection<PostViewModel> posts = Context.Posts.Select(p => new PostViewModel()
            {
                Name = p.Name,
                Content = p.Content,
                DateCreated = p.DateCreated,
                UserName = p.User.UserName,
                Id = p.Id,
                Comments = Context.Comments.Select(c => new CommentViewModel()
                {
                    Text = c.Text,
                    Author = c.Author,
                    PostId = c.PostId
                })
                .Where(c => c.PostId == p.Id)
                .ToList()
            }).ToList();

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