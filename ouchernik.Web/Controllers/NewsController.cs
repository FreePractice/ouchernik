namespace ouchernik.Web.Controllers
{
    using System.Web.Mvc;
    using Data.UniteOfWork;
    using ouchernik.Models;

    public class NewsController : BaseController
    {
        public NewsController(IOuchernikData data)
            : base(data)
        {
        }

        public NewsController(IOuchernikData data, User userProfile)
            : base(data, userProfile)
        {
        }

        public ActionResult Index()
        {
            return View();
        }
    }
}