using System;
using System.Collections.Generic;
using ControllerExtensibility.Models;
using System.Web;
using System.Web.Mvc;

namespace ControllerExtensibility.Controllers
{
    public class CustomController : Controller
    {
        public ActionResult Index(){
            return View("Result", new Result {
               ActionName="Index",
               ControllerName="Custom"});
        }

        public ViewResult List() {
            return View("Result", new Result{
                ControllerName = "Custom",
                ActionName = "List"
            });
        }
    }
}