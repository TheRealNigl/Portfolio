using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Portfolio.Controllers
{
    public class HomeController //: Controller
    {
        public IActionResult Index()
        {
            return new ContentResult { Content = "Welcome" };
        }
        

        //public string Index()
        //{
        //    return "Hello ASP.Core MVC";
        //}
    }
}