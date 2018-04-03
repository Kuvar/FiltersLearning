using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FiltersLearning.Filters
{
    public class CustomExceptionAttribute : FilterAttribute, IExceptionFilter
    {
        public void OnException(ExceptionContext filterContext)
        {
            filterContext.Controller.ViewBag.OnException = "Custom Exception: Message from OnException method.";
        }
    }
}