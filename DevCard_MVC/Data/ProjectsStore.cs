using DevCard_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;

namespace DevCard_MVC.Data
{
    public class ProjectsStore
    {
        public static List<Project> GetProjectsList()
        {
            var projects=new List<Project>
            {
                new Project(1, "تاکسی", "درخواست آنلاین خودرو", "atriya", "project-1.jpg"),
                new Project(2, "زودفود", "درخواست آنلاین غذا", "zoodfood", "project-2.jpg"),
                new Project(3, "گردشگری", "درخواست تور و سفر", "travelong agancy", "project-3.jpg"),
                new Project(4, "هتلداری", "رزرو هتل و مسافرخانه", "hosting agancy", "project-4.jpg")

            };
            return projects;

        }

        public static Project GetProjectBy(long id)
        {
            return GetProjectsList().FirstOrDefault(x => x.Id == id);
        }

    }
}
