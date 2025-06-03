using System.Web.Mvc;

namespace Velonic.Controllers
{
    public class PagesController : Controller
    {

        [ActionName("Starter-Page")]
        public ActionResult Starter_Page()
        {
            return View();
        }

        [ActionName("Contact-List")]
        public ActionResult Contact_List()
        {
            return View();
        }

        public ActionResult Profile()
        {
            return View();
        } 
        
        public ActionResult Timeline()
        {
            return View();
        } 
        
        public ActionResult Invoice()
        {
            return View();
        }
        public ActionResult FAQ()
        {
            return View();
        } 
        public ActionResult Pricing()
        {
            return View();
        }
        public ActionResult Maintenance()
        {
            return View();
        }

        [ActionName("Error-404")]
        public ActionResult Error_404()
        {
            return View();
        }

        [ActionName("Error-404-alt")]
        public ActionResult Error_404_alt()
        {
            return View();
        }
        
        [ActionName("Error-500")]
        public ActionResult Error_500()
        {
            return View();
        }
    }
}
