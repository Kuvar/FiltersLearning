using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FiltersLearning.Filters
{
    public class CustomActionAttribute : FilterAttribute, IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            filterContext.Controller.ViewBag.OnActionExecuted = "Custom Action Filter: Message from OnActionExecuted method.";
        }

        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            filterContext.Controller.ViewBag.OnActionExecuting = "Custom Action Filter: Message from OnActionExecuting method.";
        }
    }
}