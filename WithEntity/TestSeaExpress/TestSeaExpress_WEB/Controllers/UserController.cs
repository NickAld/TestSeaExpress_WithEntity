using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using TestSeaExpress_WEB.Core;

using TestSeaExpress_WCF.database;
using TestSeaExpress_WCF;

namespace TestSeaExpress_WEB.Controllers
{
    

    public class UserController : Controller
    {
        static DbSet<User> users;
        static Service1 service;
        // GET: Users
        public ActionResult Index()
        {
            service = new Service1();
            users = service.GetUsers();

            ViewBag.Title = "Пользователи";

            return View(users);
        }

        public ActionResult Index1()
        {
            return View();
        }
        
        public PartialViewResult EditUser(int idUser, bool isNew)
        {
            User user;
            if (isNew)
            {
                return PartialView("EditUser", new MyUser());
            }
            user = service.GetuserOnId(idUser);
            MyUser uNew = new MyUser()
            {
                isNew = false,
                FirstName = user.FirstName,
                LastName = user.LastName,
                MiddleName=user.MiddleName,
                Email = user.Email,
                UserID=user.UserID
            };

            return PartialView("EditUser", uNew);
        }
        [HttpPost]
        public ActionResult Save(MyUser user)
        {
            if (user.isNew)
            {
                User uNew = service.GetNewUser();
                uNew.FirstName = user.FirstName;
                uNew.LastName = user.LastName;
                uNew.MiddleName = user.MiddleName;
                uNew.Email = user.Email;
                uNew.UserID = user.UserID;
                service.AddUser(uNew);
            }
            else
            {
                User uUpdate = new TestSeaExpress_WCF.User();
                uUpdate.FirstName = user.FirstName;
                uUpdate.LastName = user.LastName;
                uUpdate.Email = user.Email;
                uUpdate.MiddleName = user.MiddleName;
                uUpdate.UserID = user.UserID;
                service.UpdateUser(uUpdate);
            }

            return RedirectToAction("Index");
        }

        public ActionResult RemoveUser(int idUser)
        {
            try
            {
                service.RemoveUser(idUser);
            }
            catch (Exception ex)
            {

            }
            return RedirectToAction("Index");
            
        }

        
    }
}