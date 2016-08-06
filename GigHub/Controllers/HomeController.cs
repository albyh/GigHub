using System.Web.Mvc;

namespace GigHub.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Msg = "Having Trouble? Send us a message.";

            return View();
        }

        [HttpPost]
        public ActionResult Contact(string message)
        {
            // TODO: Send message to HQ
            ViewBag.Msg = "Message sent. Thanks!";

            return View();
        }

        public ActionResult Serial(string letterCase)
        {
            var serial = "TESTINGSERIAL20950";
            if (letterCase == "lower")
            {
                return Content(serial.ToLower());
            }
            //return Content(serial);
            return Json(new { name = "Serial", value = serial },
                JsonRequestBehavior.AllowGet);
        }
    }
}