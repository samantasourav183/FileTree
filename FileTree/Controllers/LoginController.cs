using FileTree.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FileTree.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
   
        public ActionResult Index()
        {
            return View("login");
        }

        [HttpPost]
        public ActionResult UserLogin(FormCollection frm)
        {
            try
            {
                
                    UserMaster user = new UserMaster();
                    string Email_Address = frm["Email"];
                    string UserPassword = frm["Password"];
                    DataTable dt= user.UserLogin(Email_Address,UserPassword);
                    if(dt.Rows.Count>0)
                    {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    TempData["UnsuccesfullMessage"] ="Enter Correct Email or Password";
                }

                return View("Login");
            }
            catch
            {
                return View("Login");
            } 

           
        }

        // GET: Login/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }



        // POST: Login/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        
        public ActionResult UserInsert()
        {
            return View();
        }

        [HttpPost]
        public ActionResult UserInsert(FormCollection frm,string action)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Login/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Login/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
