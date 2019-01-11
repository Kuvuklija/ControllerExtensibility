using ControllerExtensibility.Models;
using System.Web.Mvc;
using System.Threading.Tasks;

namespace ControllerExtensibility.Controllers
{
    public class RemoteDataController : Controller{
    
        public async Task<ActionResult> Data() {

            //RemoteService service = new RemoteService();
            //string data = service.GetRemoteData();

            string data = await Task<string>.Factory.StartNew(()=> {
                return new RemoteService().GetRemoteData();
            });
            return View((object)data);
        }

        public async Task<ActionResult> ConsumeAcyncMethod() {
            string data = await new RemoteService().GetRemoteDataAsync();
            return View("Data",(object)data);
        }
    }
}