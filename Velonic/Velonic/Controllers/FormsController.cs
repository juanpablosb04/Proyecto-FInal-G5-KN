using System.Web.Mvc;

namespace Velonic.Controllers
{
    public class FormsController : Controller
    {

        [ActionName("Basic-Elements")]
        public ActionResult Basic_Elements()
        {
            return View();
        }
        [ActionName("Form-Advanced")]
        public ActionResult Form_Advanced()
        {
            return View();
        }
        
        [ActionName("Form-Validation")]
        public ActionResult Form_Validation()
        {
            return View();
        }
        
        [ActionName("Form-Wizard")]
        public ActionResult Form_Wizard()
        {
            return View();
        }
        
        [ActionName("File-Uploads")]
        public ActionResult File_Uploads()
        {
            return View();
        } 
        
        [ActionName("Form-Editors")]
        public ActionResult Form_Editors()
        {
            return View();
        }
        
        [ActionName("Image-Crop")]
        public ActionResult Image_Crop()
        {
            return View();
        }
        
        [ActionName("X-Editable")]
        public ActionResult X_Editable()
        {
            return View();
        }
    }
}
