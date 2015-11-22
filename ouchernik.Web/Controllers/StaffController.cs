namespace ouchernik.Web.Controllers
{
    using System.Web.Mvc;
    using Data.UniteOfWork;
    using ouchernik.Models;

    public class StaffController : BaseController
    {
        public StaffController(IOuchernikData data)
            : base(data)
        {
        }

        public StaffController(IOuchernikData data, User userProfile)
            : base(data, userProfile)
        {
        }

        public ActionResult Index()
        {
            return View();
        }
    }
}