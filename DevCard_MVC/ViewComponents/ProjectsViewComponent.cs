using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevCard_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevCard_MVC.ViewComponents
{
    public class ProjectsViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var projects = new List<Project>
            {
                new Project(1,"تاکسی","درخواست آنلاین خودرو","atriya","project-1.jpg"),
                new Project(2,"زودفود","درخواست آنلاین غذا","zoodfood","project-2.jpg"),
                new Project(1,"گردشگری","درخواست تور و سفر","travelong agancy","project-3.jpg"),
                new Project(1,"هتلداری","رزرو هتل و مسافرخانه","hosting agancy","project-4.jpg")

            };

            return View("_Projects",projects);
        }
    }
}
