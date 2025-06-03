using System.Web.Mvc;

namespace Velonic.Controllers
{
    public class MapsController : Controller
    {

        [ActionName("Google-Maps")]
        public ActionResult Google_Maps()
        {
            return View();
        }
        
        [ActionName("Vector-Maps")]
        public ActionResult Vector_Maps()
        {
            return View();
        }
    }
}
