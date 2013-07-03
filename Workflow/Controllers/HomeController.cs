using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Workflow.Controllers
{
    public class HomeController : Controller
    {        
        public ActionResult Index(int? id)
        {            
            ViewBag.Message = "Hello, MVC world!" + id;

            Workflow.Models.Person p = new Workflow.Models.Person();
            p.name = "gubo";
            p.age = 33;

            return View(p);
        }

        public ActionResult About()
        {
            return View();
        }

        public string Hello(int? id, string param)
        {
            string result = string.Empty;
            if (id != null)
            {
                result = "Hello, HomeController Hello function!";
            }
            else
            {
                result = "Hello, function with id" + id;
            }

            if (param != null)
            {
                string paramString = "param is" + param;
                result += " " + paramString;
            }

            return HttpUtility.HtmlEncode(result);
        }
    }
}
