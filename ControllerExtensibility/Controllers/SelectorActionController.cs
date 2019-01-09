using ControllerExtensibility.Models;
using ControllerExtensibility.Infrastructure;
using System.Web.Mvc;

namespace ControllerExtensibility.Controllers
{
    public class SelectorActionController : Controller
    {
        public ActionResult Index(){
            return View("Result", new Result {
                ControllerName="SelectorAction",
                ActionName="Index"
            });
        }

        [Local]
        [ActionName("Index")]
        public ActionResult LocalIndex() {
            return View("Result", new Result {
               ControllerName="SelectorAction",
               ActionName="LocalIndex"
            });
        }

        //without 404-error if action has't found
        protected override void HandleUnknownAction(string actionName){
            Response.Write(string.Format("You requested the {0} action",actionName));
        }
    }
}