using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;
using site.Models;
namespace site.Controllers
{
    public class ShopController: Controller
    {   

        private List<Item> List2Buy()
        {
            return null;
        }
        private bool LoggedIn()
        {
            return Globals.isLoggedIn(HttpContext.Session.GetString(Globals.STR_USER_ID_CONSUMER));
        }

        private string UserId()
        {
            return HttpContext.Session.GetString(Globals.STR_USER_ID_CONSUMER);
        }
        public IActionResult Index()
        {
            var db = new teslaContext();
            var list = db.Item2sell.ToList();
            return View(list);
        }

        public IActionResult Pick(string id)
        {
            var db = new teslaContext();
            var intId =  Int32.Parse(id);
            var obj = db.Item2sell.Where(x=> x.Item2sellno == intId).First();
            return View(obj);
        }


        public async Task<IActionResult> Buy(string id)
        {
            if(!LoggedIn()) return Redirect("/Login/Login");
            var db = new teslaContext();
            var intId =  Int32.Parse(id);
            var obj = db.Item2sell.Where(x=> x.Item2sellno == intId).First();
            var listEmployee = db.Employee.ToList();

            //eager loading begin
            foreach(var worker in listEmployee)
            {
                worker.Job = db.Job.Where(x=> x.Employeeemail == worker.Email).ToList();
            }
            //eager loading end


            //assign job to free worker
            //find worker with least amount of job
            var jobcount = Int32.MaxValue;
            Employee pickedWorker = null;
            foreach(var worker in listEmployee)
            {
                if(worker.Job.Count < jobcount)
                {
                    jobcount = worker.Job.Count;
                    pickedWorker = worker;
                }
            }
            var job = new Job();
            job.Employeeemail = pickedWorker.Email;
            job.Jobid = Globals.GenerateRandomInt();
            job.Lastupdated = DateTime.Now;
            job.Progress = Globals.STR_ORDER_PLACED;
            
            //end assign job
            var item = new Item();
            item.Itemno = Globals.GenerateRandomInt();
            item.Item2sellno = intId;
            item.Jobid = job.Jobid;
            item.Email = UserId();
            item.Item2sell = obj;
            item.Description = Globals.STR_ORDER_PLACED;

            db.Item.Add(item);
            db.Job.Add(job);
            await db.SaveChangesAsync();
            return Redirect("/Shop/Index");
        }

        public IActionResult BuyList()
        {
            if(!LoggedIn()) return Redirect("/Login/Login");
            var db = new teslaContext();
            var list = db.Item.Where(x=> x.Email == UserId()).ToList();
            var carlist = db.Item2sell.ToList();
            foreach(var l in list)
                l.Item2sell = carlist.Where(x => x.Item2sellno == l.Item2sellno).First();
            return View(list);
        }

        public IActionResult Progress(string id)
        {
            if(!LoggedIn()) return Redirect("/Login/Login");
            var db = new teslaContext();
            var intId =  Int32.Parse(id);
            var obj = db.Item.Where(x=> x.Itemno == intId).First();
            var job = db.Job.Where(x=> x.Jobid == obj.Jobid).First();
            //eager loading
            obj.Item2sell = db.Item2sell.Where(x=> x.Item2sellno == obj.Item2sellno).First();

            //eager loading end
            var jobitem = new JobItemViewModel();
            jobitem.Job = job;
            jobitem.JobItem = obj;
            return View(jobitem);
        }

        public async Task<IActionResult> RemoveList(string id)
        {
            if(!LoggedIn()) return Redirect("/Login/Login");
            var db = new teslaContext();
            var intId =  Int32.Parse(id);
            var obj = db.Item.Where(x=> x.Itemno == intId).First();
            db.Item.Remove(obj);
            await db.SaveChangesAsync();
            return Redirect("/Shop/BuyList");
        }

        [HttpPost]
        public async Task <IActionResult> ClearList()
        {
            if(!LoggedIn()) return Redirect("/Login/Login");
            var db = new teslaContext();
            var list = db.Item.Where(x=> x.Email == UserId() && x.Description != Globals.STR_ORDER_PLACED).ToArray();
            foreach(var o in list)
                db.Remove(o);
            await db.SaveChangesAsync();
            return Redirect("/Shop/Index");
        }


    }
}