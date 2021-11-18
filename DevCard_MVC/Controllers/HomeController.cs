using System.Collections.Generic;
using System.Diagnostics;
using DevCard_MVC.Data;
using DevCard_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DevCard_MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly  List<Service> _services= new List<Service>
        {
            new Service(1,"طلایی"),
            new Service(2,"نقره ای"),
            new Service(3,"پلاتین"),
            new Service(4,"الماس")
        
        };
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ProjectDetails(long id)
        {
            var project = ProjectsStore.GetProjectBy(id);
            return View(project);
        }
        public IActionResult ArticleDetails(long id)
        {
            var article = ArticlesStore.GetArticleBy(id);
            return View(article);
        }
        [HttpGet]
        public IActionResult Contact()
        {
            var model = new Contact();
            {
                model.Services = new SelectList(_services, "Id", "ServiceName");
            }
            return View(model);
        }

        [HttpPost]
        public IActionResult Contact(Contact form)
        {
            form.Services= new SelectList(_services, "Id", "ServiceName");
            if (!ModelState.IsValid)
            {
                ViewBag.Error = "اطلاعات وارد شده صحیح نیست";
                return View(form);
            }
            else
            {
                ModelState.Clear();
                form = new Contact();
                form.Services = new SelectList(_services, "Id", "ServiceName");
                ViewBag.Success = "اطلاعات وارد شده ثبت شد.";
                return View(form);
                
            }
            

        }
        


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}