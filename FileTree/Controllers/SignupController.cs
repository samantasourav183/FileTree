using FileTree.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FileTree.Controllers
{
    public class SignupController : Controller
    {
        // GET: Signup
        public ActionResult Index()
        {
            return View("signup");
        }
        public ActionResult UserSignup(FormCollection frm,string action)
        {
            try
            {
                if (action == "Signup")
                {
                    UserMaster user = new UserMaster();
                    string Name = frm["UserName"];
                    string Role = frm["UserRole"];
                    string Email_Address = frm["Email_Address"];
                    string UserPassword = frm["UserPassword"];
                    string ConfirmPassword = frm["ConfirmPassword"];
                    bool i = user.InsertUser(Name,Role,Email_Address,UserPassword);
                    if(i == true)
                    {
                        TempData["Message"] = "Signup Succesfully";
                       
                    }

                    
                }
                return View("signup");
            }
            catch
            {
                return View("signup");
            }
           
        }
        // GET: Signup/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Signup/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Signup/Create
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
                return View("I");
            }
        }

        // GET: Signup/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Signup/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
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

        // GET: Signup/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Signup/Delete/5
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
