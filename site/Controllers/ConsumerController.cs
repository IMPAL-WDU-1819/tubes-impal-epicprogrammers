using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;
using site.Models;
namespace site.Controllers
{
    public class ConsumerController: Controller
    {   
        /* POST:
        *   /Post
        */
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Post(Consumer consumer)
        {
            if(ModelState.IsValid)
            {
                teslaContext dbContext = new teslaContext();
                dbContext.Add(consumer);
                await dbContext.SaveChangesAsync();    
                System.Diagnostics.Debug.WriteLine("[INFO]SAVED");
            }
            System.Diagnostics.Debug.WriteLine("[WARN]post!");
            return Content("Hello "+consumer.Nama);
        }

        public IActionResult Index()
        {
            //HttpContext.Session.SetString(SessionName, GenerateRandomString());
            System.Diagnostics.Debug.WriteLine("[WARN]INPUT DATA NOW!");
            for(int i=0;i<5;i++)
                System.Diagnostics.Debug.WriteLine("[WARN]" + WebsiteConfig.ConnectionString );
            return View();
        }

    }
}