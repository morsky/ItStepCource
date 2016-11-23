using System.Web.Mvc;
using BlogSystem.Data;

namespace BlogSystem.Controllers
{
    public abstract class BaseController : Controller
    {
        public BaseController()
            : this (new BlogSystemDbContext())
        {
        }

        public BaseController(BlogSystemDbContext context)
        {
            this.Context = context;
        }

        protected BlogSystemDbContext Context { get; set; }
    }
}