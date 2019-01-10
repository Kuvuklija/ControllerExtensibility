using System;
using ControllerExtensibility.Models;
using System.Linq;
using System.Web.SessionState;
using System.Web.Mvc;

namespace ControllerExtensibility.Controllers
{
    [SessionState(SessionStateBehavior.Disabled)] //turn of cookie
    public class FastController : Controller{
    
        public ActionResult Index(){
            return View("Result", new Result {
                ControllerName="Fast",
                ActionName="Index"
            });
        }
    }
}