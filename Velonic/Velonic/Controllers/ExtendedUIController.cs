using System.Web.Mvc;

namespace Velonic.Controllers
{
    public class ExtendedUIController : Controller
    {
        public ActionResult Portlets()
        {
            return View();
        }
        
        public ActionResult Scrollbar()
        {
            return View();
        }


        [ActionName("Range-Slider")]
        public ActionResult Range_Slider()
        {
            return View();
        }
        
        public ActionResult Scrollspy()
        {
            return View();
        }
    }
}
