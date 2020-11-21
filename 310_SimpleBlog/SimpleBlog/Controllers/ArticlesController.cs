using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SimpleBlog.Models;

namespace SimpleBlog.Controllers
{
    public class ArticlesController : Controller
    {
        // GET: Articles
        public ActionResult Index() {
            List<ArticlesModel> articles = new List<ArticlesModel>();
            articles.Add(new ArticlesModel(
                "Стартап от Google",
                "Это самый знаменитый стартап, о котором говорит весь мир",
                "Мистер Пупкин"));
            articles.Add(new ArticlesModel(
                "Немного о Facebook",
                "Facebook способствовал увеличению голосов Байдена на выборах",
                "Мистер Пупкинский"));
            articles.Add(new ArticlesModel(
                "Новости из Кремниевой Долины",
                "ИТ-гиганты со всего мира стремяться попасть скорее туда",
                "Мистер ИТшник"));

            return View(articles);
        }
    }
}