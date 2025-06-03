using System.Web.Mvc;

namespace Velonic.Controllers
{
    public class LayoutsController : Controller
    {
        public ActionResult Horizontal()
        {
            return View();
        }


        [ActionName("Light-Sidebar")]
        public ActionResult Light_Sidebar()
        {
            return View();
        }

        [ActionName("Small-Sidebar")]
        public ActionResult Small_Sidebar()
        {
            return View();
        }


        [ActionName("Collapsed-Sidebar")]
        public ActionResult Collapsed_Sidebar()
        {
            return View();
        }


        [ActionName("Unsticky-Layout")]
        public ActionResult Unsticky_Layout()
        {
            return View();
        }


        [ActionName("Boxed-Layout")]
        public ActionResult Boxed_Layout()

        {
            return View();
        }
    }
}
