using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PruebaVue.Models;

namespace PruebaVue.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            SomeModel jsonModel = new SomeModel();
            jsonModel.UserId = "cdb86aea-e3d6-4fdd-9b7f-55e12b710f78";
            jsonModel.UserName = "iggy";

            var serializedJsonModel = JsonConvert.SerializeObject(jsonModel);
            ViewBag.name = serializedJsonModel;
            return View();
        }
        public class SomeModel
        {
            public string UserId { get; set; }
            public string UserName { get; set; }
        }
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
