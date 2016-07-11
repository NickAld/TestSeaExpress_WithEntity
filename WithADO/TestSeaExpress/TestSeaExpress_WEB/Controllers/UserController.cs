using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestSeaExpress_WEB.Core;
using TestSeaExpress_WEB;
using TestSeaExpress_WCF;

using DataBase;

namespace TestSeaExpress_WEB.Controllers
{
    public class UserController : Controller
    {
        List<Person> users;
        static Service1 service;
        // GET: Users
        public ActionResult Index()
        {
            service = new Service1(ConfigurationManager.ConnectionStrings["TestSeaExpress1"].ConnectionString);
            users = service.GetUsers();

            ViewBag.Title = "Пользователи";

            return View(users);
        }

        public ActionResult Index1()
        {
            return View();
        }
        
        public PartialViewResult EditUser(int? idUser, bool isNew)
        {
            Person user;
            if (isNew)
            {
                return PartialView("EditUser", new MyUser());
            }
            int i;
            if (idUser == null)
                i = default(int);
            else
                i = idUser.Value;
           user = service.GetuserOnId(i);
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
                Person uNew = service.GetNewUser();
                uNew.FirstName = user.FirstName;
                uNew.LastName = user.LastName;
                uNew.MiddleName = user.MiddleName;
                uNew.Email = user.Email;
                uNew.UserID = user.UserID;
                service.AddUser(uNew);
            }
            else
            {
                Person uUpdate = new Person();
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