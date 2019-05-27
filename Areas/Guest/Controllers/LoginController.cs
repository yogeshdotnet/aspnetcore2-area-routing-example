using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Core_Basic.Areas.Guest.Controllers
{
    [Area("Guest")]
    public class GuestLoginController : Controller
    {
        public IActionResult Index()
        {
            return Content("Area Guest Login Controller and Index Action");
        }
    }
}