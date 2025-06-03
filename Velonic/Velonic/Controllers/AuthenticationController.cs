using System.Web.Mvc;

namespace Velonic.Controllers
{
    public class AuthenticationController : Controller
    {
        public ActionResult Login()
        {
            return View();
        }
        
        public ActionResult Register()
        {
            return View();
        } 
        
        public ActionResult Logout()
        {
            return View();
        }

        [ActionName("Forgot-Password")]
        public ActionResult Forgot_Password()
        {
            return View();
        }
        
        [ActionName("Lock-Screen")]
        public ActionResult Lock_Screen()
        {
            return View();
        }
    }
}
