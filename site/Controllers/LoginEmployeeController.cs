using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using site.Models;

namespace site.Controllers
{
    public class LoginEmployeeController: Controller
    {
        

        public IActionResult Logout()
        {
            HttpContext.Session.SetString(Globals.STR_USER_ID_CONSUMER, "");
            HttpContext.Session.SetString(Globals.STR_USER_ID_EMPLOYEE, "");
            HttpContext.Session.SetString(Globals.STR_LOGGED_AS , "");
            return Redirect("/");
        }

        [HttpPost]
        public async Task<IActionResult> Login(UserViewModel user)
        {
            var db = new teslaContext();
            //IQueryable<Consumer> FindUser = null;
            if(ModelState.IsValid && user.Username != "0")
            {
                var FindUser = db.Employee.Where( x => user.Username == x.Username  && user.Pass == x.Pass );
                if(FindUser.Count() == 0 )
                {
                    ModelState.AddModelError("Credential","Password atau username salah");
                    return View();
                }
                    
                var listUsers = FindUser.ToArray();
                listUsers[0].Lastlogin = DateTime.Now;
                db.Update(listUsers[0]);
                await db.SaveChangesAsync();
                HttpContext.Session.SetString(Globals.STR_USER_ID_CONSUMER, "");
                HttpContext.Session.SetString(Globals.STR_USER_ID_EMPLOYEE, listUsers[0].Email );
                HttpContext.Session.SetString(Globals.STR_LOGGED_AS, Globals.STR_EMPLOYEE);
                return Redirect("/Employee/Index");
            }
            return View();
            
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }


        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SignUp(Employee employee)
        {
            var db = new teslaContext();
            if(ModelState.IsValid)
            {
                db.Employee.Add(employee);
                await db.SaveChangesAsync();
                HttpContext.Session.SetString(Globals.STR_USER_ID_EMPLOYEE,employee.Email);
                return Redirect("/");
            }
            return View();
        }
    }
}