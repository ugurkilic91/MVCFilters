using System.Web.Mvc;

namespace MVCFilters.Filters
{
    public class ErrorAttribute: HandleErrorAttribute
    {
        public override void OnException(ExceptionContext filterContext)
        {

            if (filterContext.HttpContext.IsCustomErrorEnabled)
            {
                filterContext.ExceptionHandled = true;

            }
            base.OnException(filterContext);
            //OVERRIDE THE 500 ERROR  
            filterContext.HttpContext.Response.StatusCode = 200;
        }
    }
}