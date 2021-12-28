using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jkhkhkuhuh.Controllers
{
    public class BlogCatController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
