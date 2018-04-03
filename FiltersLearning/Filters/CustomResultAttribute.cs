using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FiltersLearning.Filters
{
    public class CustomResultAttribute : FilterAttribute, IResultFilter
    {
        public void OnResultExecuted(ResultExecutedContext filterContext)
        {
            filterContext.Controller.ViewBag.OnResultExecuted = "Custom Action Filter: Message from OnResultExecuted method.";
        }

        public void OnResultExecuting(ResultExecutingContext filterContext)
        {
            filterContext.Controller.ViewBag.OnResultExecuting = "Custom Action Filter: Message from OnResultExecuting method.";
        }
    }
}