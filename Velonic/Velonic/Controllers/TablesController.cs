using System.Web.Mvc;

namespace Velonic.Controllers
{
    public class TablesController : Controller
    {

        [ActionName("Basic-Tables")]
        public ActionResult Basic_Tables()
        {
            return View();
        }

        [ActionName("Data-Tables")]
        public ActionResult Data_Tables()
        {
            return View();
        }
        
        [ActionName("Editable-Tables")]
        public ActionResult Editable_Tables()
        {
            return View();
        }
        
        [ActionName("Responsive-Table")]
        public ActionResult Responsive_Table()
        {
            return View();
        }
    }
}
