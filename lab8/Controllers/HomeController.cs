using System.Data;
using lab8.Models;
using System.Linq;
using System.Web.Mvc;

namespace lab8.Controllers
{
    public class HomeController : Controller
    {
        private readonly SimpleBlogEntities _blogs = new SimpleBlogEntities();

        //
        // GET: /Home/

        [HttpGet]
        public ActionResult Index() => View("IndexView", _blogs.Blog.ToList());

        public ActionResult BlogView(int id) => View("BlogView", _blogs.Blog.Find(id));

        [HttpGet]
        public ActionResult EditBlog(int id) => View("EditBlog", _blogs.Blog.Find(id));

        [HttpPost]
        public ActionResult EditBlog(Blog blog)
        {
            _blogs.Entry(blog).State = EntityState.Modified;
            _blogs.SaveChanges();
            return RedirectToAction("BlogView", new {blog.Id});
        }

        public ActionResult DeleteBlog(int id)
        {
            var blog = _blogs.Blog.Find(id);
            _blogs.Entry(blog).State = EntityState.Deleted;
            _blogs.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult AddBlog()
        {
            var blog = _blogs.Blog.Create();
            blog.Name = blog.Descroption = blog.Url = "";
            _blogs.Blog.Add(blog);
            _blogs.SaveChanges();
            return RedirectToAction("EditBlog", new {blog.Id});
        }

        [HttpGet]
        public ActionResult PostView(int id) => View("PostView", _blogs.Post.Find(id));

        [HttpPost]
        public ActionResult PostView(Comment comment)
        {
            _blogs.Comment.Add(comment);
            _blogs.SaveChanges();
            return RedirectToAction("PostView", new {id = comment.IdPost});
        }
    }
}
