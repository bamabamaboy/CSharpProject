using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SimpleBlog.Models;

namespace SimpleBlog.Controllers
{
    public class UsersController : Controller
    {
        // GET: Users
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult UsersList() {

            List<UsersModel> users = new List<UsersModel>();
            users.Add(new UsersModel("Tom", "Simpson", 22, true));
            users.Add(new UsersModel("Bany", "Baks", 34, false));
            users.Add(new UsersModel("Regina", "Green", 18, false));


            return View(users);
        }

    }
}