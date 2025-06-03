using System.Web.Mvc;

namespace Velonic.Controllers
{
    public class ChartsController : Controller
    {

        [ActionName("Apex-Charts")]
        public ActionResult Apex_Charts()
        {
            return View();
        }
        
        public ActionResult Chartjs()
        {
            return View();
        }
        [ActionName("Sparkline-Charts")]
        public ActionResult Sparkline_Charts()
        {
            return View();
        }
    }
}
