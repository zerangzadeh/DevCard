using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Threading.Tasks;

namespace DevCard_MVC.Controllers
{
    public class TestController : Controller
    {
        //public IActionResult Index()
        //{
        //    return PartialView("Footer");
        //}

        //public ContentResult Index2()
        //{
        //    return Content("<h2 style='color='red''>It is a test Retuen content</h2>","text/html");
        //}

        //public FileResult Index3()
        //{
        //    var fileByte = System.IO.File.ReadAllBytes("wwwroot/newFile.txt");
        //    string fileName = "MyFile.txt";
        //    return File(fileByte, MediaTypeNames.Text.Plain, fileName);
            
        //}

        //public JsonResult Index4()
        //{
        //    return Json(new
        //    {
        //        Id=1,
        //        FName="Ali",
        //        LName="Alipor",
        //        Job="Artiteture",
        //        Address="Iran,AWZ"
        //    });
        //}

        //public JavaScriptResult index5()
        //{
        //    return new JavaScriptResult("alert(' Hi,everybody!')");
        //}

        public class JavaScriptResult : ContentResult
        {
            public JavaScriptResult(string data)
            {
                Content = data;
                ContentType = "application/javascript";
            }
        }
    }
}
