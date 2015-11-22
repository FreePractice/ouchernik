namespace ouchernik.Web.Controllers
{
    using System.Web.Mvc;
    using Data.UniteOfWork;
    using ouchernik.Models;

    public class ResourcesController : BaseController
    {
        public ResourcesController(IOuchernikData data)
            : base(data)
        {
        }

        public ResourcesController(IOuchernikData data, User userProfile)
            : base(data, userProfile)
        {
        }

        public ActionResult Index()
        {
            return View();
        }
    }
}