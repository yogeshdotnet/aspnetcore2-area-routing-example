using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Core_Basic.Controllers
{
    
    public class HomeController : Controller
    {
       
        public IActionResult Index()
        {
            return Content("Home Controller Index Action is called");
        }
      
     
    }
}