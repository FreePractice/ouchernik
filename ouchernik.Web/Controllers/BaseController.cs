namespace ouchernik.Web.Controllers
{
    using System;
    using System.Web.Routing;
    using Data.UniteOfWork;
    using ouchernik.Models;
    using System.Web.Mvc;
    using System.Linq;

    public abstract class BaseController : Controller
    {
        private IOuchernikData data;
        private User userProfile;

        protected BaseController(IOuchernikData data)
        {
            this.Data = data;
        }

        protected BaseController(IOuchernikData data, User userProfile)
            : this(data)
        {
            this.UserProfile = userProfile;
        }

        protected IOuchernikData Data { get; private set; }

        protected User UserProfile { get; private set; }

        protected override IAsyncResult BeginExecute(RequestContext requestContext, AsyncCallback callback, object state)
        {
            if (requestContext.HttpContext.User.Identity.IsAuthenticated)
            {
                var username = requestContext.HttpContext.User.Identity.Name;
                var user = this.Data.Users.All().FirstOrDefault(u => u.UserName == username);
                this.UserProfile = user;
            }

            return base.BeginExecute(requestContext, callback, state);
        }
    }
}