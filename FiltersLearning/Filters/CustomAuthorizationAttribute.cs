using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FiltersLearning.Filters
{
    public class CustomAuthorizationAttribute : FilterAttribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationContext filterContext)
        {
            filterContext.Controller.ViewBag.OnAuthorization = "Custom Authorization: Message from OnAuthorization method.";
        }
    }
}