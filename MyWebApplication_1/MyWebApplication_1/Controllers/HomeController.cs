using MyWebApplication_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyWebApplication_1.Controllers
{
    public class HomeController : Controller
    {
        ForumContext bd = new ForumContext();
        string forumBack = "<br><form action=\"/Home/\"><button>Вернуться к списку тем</button></form>";
        public ActionResult Index()
        {
            IEnumerable<ForumTheme> forumThemes = bd.ForumThemes;

            ViewBag.ForumThemes = forumThemes;

            return View();
        }

        [HttpGet]
        public ActionResult ForumTheme(int id = 1)
        {   
            ViewBag.NeedTheme = bd.ForumThemes.Find(id);
            bd.ForumThemes.Find(id).Views++;
            bd.SaveChanges();

            return View();
        }

        [HttpGet]
        public string Delete(int id)
        {
            string button = forumBack;
            ForumTheme forumTheme = bd.ForumThemes.Find(id);
            if (forumTheme != null)
            {
                bd.ForumThemes.Remove(forumTheme);
                bd.SaveChanges();
            }
            else return "Нет такой темы" + button;
            return "Тема удалена" + button;
        }

        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }


        [HttpPost]
        public string Add(ForumTheme forumTheme)
        {
            bd.ForumThemes.Add(forumTheme);
           
            bd.SaveChanges();
                    
            return "Тема форума добавлена" + forumBack;
        }
    }
}