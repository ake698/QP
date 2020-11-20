using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Diagnostics;

namespace QP.Extensions
{
    public class HeaderFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var ua = context.HttpContext.Request.Headers["User-Agent"].ToString().ToLower();
            var url = context.HttpContext.Request.Path;
            if (url == "/transfer")
                return;
            Debug.WriteLine(ua);
            if (ua.Contains("micromessenger"))
            {
                context.Result = new PartialViewResult { ViewName = "transfer" };
                return;
            }
            if(ua.Contains("qq") && !ua.Contains("mqqbrowser"))
            {
                context.Result = new PartialViewResult { ViewName = "transfer" };
                return;
            }
            base.OnActionExecuting(context);
        }
    }
}
