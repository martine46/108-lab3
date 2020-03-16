using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using dotnet2.Models;

namespace dotnet2.Controllers
{
    public class CatalogController : Controller{
        public IActionResult Index(){
            return View();
        }
        public IActionResult Register(){
            return View();
        }

        [HttpPost]
        public IActionResult saveCar( [FromBody] Car theCar   ){
            return Json(theCar);
        }

    }
}