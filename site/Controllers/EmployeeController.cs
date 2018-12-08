using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;
using System.Linq;
using System.Collections.Generic;
using System;
using site.Models;

namespace site.Controllers
{
    public class EmployeeController: Controller
    {   
        private bool LoggedIn()
        {
            return Globals.isLoggedInEmployee(HttpContext.Session.GetString(Globals.STR_USER_ID_EMPLOYEE));
        }

        private string UserId()
        {
            return HttpContext.Session.GetString(Globals.STR_USER_ID_EMPLOYEE);
        }

        public IActionResult Index()
        {
            if(!LoggedIn())
                return Redirect("/LoginEmployee/Login");
            var db = new teslaContext();
            var recent5Jobs = db.Job.OrderBy(x=> x.Lastupdated)
                            .Where(x=> x.Employeeemail == UserId())
                            .Take(6)
                            .ToList();
            var items = db.Item.ToList();
            var itemToSell = db.Item2sell.ToList();
            //eager loading

            
            foreach(var job in recent5Jobs)
            {
                 job.Item = items.Where(x=> x.Jobid == job.Jobid).First();
                 job.Item.Item2sell = itemToSell.Where(x=> x.Item2sellno == job.Item.Item2sellno).First();    
            }   
            //eager loading end
            return View(recent5Jobs.ToList());
        }

        public IActionResult Order()
        {
            if(!LoggedIn())
                return Redirect("/LoginEmployee/Login");
                var db = new teslaContext();
            var Jobs = db.Job.OrderBy(x=> x.Lastupdated)
                            .Where(x=> x.Employeeemail == UserId())
                            .ToList();
            var items = db.Item.ToList();
            var itemToSell = db.Item2sell.ToList();
            //eager loading

            
            foreach(var job in Jobs)
            {
                 job.Item = items.Where(x=> x.Jobid == job.Jobid).First();
                 job.Item.Item2sell = itemToSell.Where(x=> x.Item2sellno == job.Item.Item2sellno).First();    
            }   
            return View(Jobs);
        }

        public IActionResult DetailedOrder(string id)
        {
            if(!LoggedIn()) 
                return Redirect("/LoginEmployee/Login");
            var db = new teslaContext();
            
            var job = db.Job.Where(x=>x.Jobid == Int32.Parse(id)).First();
            if(job==null) return NotFound();
            //eager loading
            job.Item = db.Item.Where(x=>x.Jobid == job.Jobid).First();
            job.Item.Item2sell = db.Item2sell.Where(x=> x.Item2sellno == job.Item.Item2sellno).First();
            var item2parts  = db.Part2item.Where(x=>x.Itemnoitem == job.Item.Item2sellno).ToList();
            var parts  = db.Part.ToList();
            foreach (var item in item2parts)
            {
                item.Part = parts.Where(x=>x.Itemno == item.Itemnopart).First();
            }
            //eager loading end
            var jobpart = new JobPartViewModel();
            jobpart.Job = job;
            jobpart.Parts = item2parts;
            return View(jobpart);
        }
        [HttpPost]
        public async Task<IActionResult> ProgressUpdate(JobPartViewModel jobPartViewModel)
        {
            if(!LoggedIn()) 
                return Redirect("/LoginEmployee/Login");
            var db = new teslaContext();
            var job2update = db.Job.Where(x=> x.Jobid == jobPartViewModel.Job.Jobid).First();
            var item2update = db.Item.Where(x=> x.Jobid == jobPartViewModel.Job.Jobid ).First();
            if(job2update.Employeeemail != UserId()) return Forbid();
            job2update.Progress = jobPartViewModel.Job.Progress;
            item2update.Description = Globals.STR_ORDER_ACQUIRE_PARTS;
            job2update.Lastupdated = DateTime.Now;
            db.Job.Update(job2update);
            db.Item.Update(item2update);
            await db.SaveChangesAsync();
            return Redirect("/Employee/Index");
        }

    }
}