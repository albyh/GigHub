using System.IO.Ports;
using System.Web.Mvc;

namespace GigHub.Controllers
{
    public class GigsController : Controller
    {
        // GET: Gigs
        public ActionResult Create()
        {
            return View();
        }

        //public ActionResult Serial()
        //{
        //    ViewBag.paragraph = "Hello World";
        //    return Json(new { name = "Serial", value = serial },
        //        JsonRequestBehavior.AllowGet);
        //}
    }
}