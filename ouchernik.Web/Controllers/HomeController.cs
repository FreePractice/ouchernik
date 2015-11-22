

namespace ouchernik.Web.Controllers
{
    using ouchernik.Data.UniteOfWork;
    using ouchernik.Models;
    using System.Web.Mvc;

    public class HomeController : BaseController
    {
        public HomeController(IOuchernikData data)
            : base(data)
        {
        }

        public HomeController(IOuchernikData data, User userProfile)
            : base(data, userProfile)
        {
        }

        public ActionResult Index()
        {
            return View();
        }
    }
}