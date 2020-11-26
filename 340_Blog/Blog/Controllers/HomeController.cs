using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Blog.Models;
using DataLibrary.Logic;

namespace Blog.Controllers {
    public class HomeController : Controller {
        public ActionResult Index() {
            return View();
        }

        public ActionResult About() {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact() {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult UsersCreate() {
            return View();
        }

        [HttpPost]
        public ActionResult UsersCreate(UsersModel model) {

            if (ModelState.IsValid) {
                UsersDB.creatUser(model.age, model.name, model.surname, model.email, model.password);
                return RedirectToAction("Index");
            }

            return View();
        }

        public ActionResult viewUsers() {

            var data = UsersDB.loadUsers();
            List<UsersModel> users = new List<UsersModel>();

            foreach (var el in data) {
                users.Add(new UsersModel {
                    age = el.age,
                    name = el.name,
                    surname = el.surname,
                    email = el.email,
                    password = el.password
                });
            }


            return View(users);
        }

    }
}