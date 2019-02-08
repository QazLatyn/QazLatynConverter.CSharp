using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using QazLatyn;

namespace QazLatynConverter.NetCoreWeb.Example.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cyrl2Latyn(string cyrlText)
        {
           string latynText =  QazLatynHelper.Cyrl2Latyn(cyrlText);
            return Json(new { latynText });
        }
    }
}