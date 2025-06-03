using System.Web.Mvc;

namespace Velonic.Controllers
{
    public class IconsController : Controller
    {


        [ActionName("Remix-Icons")]
        public ActionResult Remix_Icons()
        {
            return View();
        }

        [ActionName("Bootstrap-Icons")]
        public ActionResult Bootstrap_Icons()
        {
            return View();
        }

        [ActionName("Material-Design-Icons")]
        public ActionResult Material_Design_Icons()
        {
            return View();
        }
    }
}
