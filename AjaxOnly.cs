// Create a file named AjaxOnlyAttribute and paste the code below.
// Make sure to update the namespace to match your project, e.g., MySite.Models.

using System.Web.Mvc;

namespace MySite.Models
{
    public class AjaxOnlyAttribute : ActionFilterAttribute
        {
            public override void OnActionExecuting(ActionExecutingContext filterContext)
            {
                if (!filterContext.HttpContext.Request.IsAjaxRequest())
                    filterContext.HttpContext.Response.Redirect("/Error/NotFound/");
            }
        }
}
