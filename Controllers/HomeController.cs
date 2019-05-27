using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Core_Basic.Controllers
{
    //[Route("MyHome")]
    // [Route("")] For Empty Controller Name
  [Route("[controller]")] // controller is just placeholder to get current place holder
  [Route("")]
    public class HomeController : Controller
    {
        [Route("Index")]

        [Route("")]
        public IActionResult Index()
        {
            return Content("Index Action of Home Controller");
        }
        [Route("Contact")]
        public IActionResult ContactUs()
        {
            return Content("ContactUs Action of Home Controller");
        }
        // Add Multiple Routes
        [Route("feedback1")] // Access Using https://localhost:44347/Home/feedback1
       // [Route("")] //https://localhost:44347/Home
        [Route("myfeedback")] // https://localhost:44347/Home/myfeedback
        [Route("my/myfeedback")] // https://localhost:44347/Home/my/myfeedback
        [Route("[action]")] // // https://localhost:44347/Home/feedback
        public IActionResult Feedback()
        {
            return Content("FeedBack Action of Home Controller");
        }
        // Route Constraints
        [Route("calculate/{x:int}/{y:int}")]  // https://localhost:44347/Home/Calculate/85/30
        public IActionResult Add(int x, int y)
        {
            return Content("Addition is = " + (x + y));
        }
    }
}