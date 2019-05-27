using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Core_Basic.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("")]
    public class DashBoardController : Controller
    {

        [Route("[area]/Login")] // https://localhost:44347/Admin/Login
        
        public IActionResult Index()
        {
            return Content("Index Action of Admin Area DashBoard Controller");
        }
    }
}