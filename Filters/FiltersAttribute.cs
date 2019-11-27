using System.Web.Mvc;

namespace MVCFilters.Filters
{
    public class FiltersAttribute: ActionFilterAttribute
    {
  
        /// <summary>
        /// OnActionExecuted : Action metod çalıştırıldıktan sonra devreye giren metottur.
        /// </summary>
        /// <param name="filterContext"></param>
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            
            //if (filterContext.RequestContext.HttpContext.Session["Kullanici"] == null)
            //    filterContext.RequestContext.HttpContext.Response.Redirect("http://www.google.com");
            base.OnActionExecuted(filterContext);
        }
        /// <summary>
        /// OnActionExecuting : Action metod tetiklendiği anda devreye giren metoddur.
        /// </summary>
        /// <param name="filterContext"></param>
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var userAgent = filterContext.HttpContext.Request.ServerVariables["HTTP_USER_AGENT"];
            if (userAgent.IndexOf("MSIE") != -1)
                filterContext.Result = new ContentResult()
                    { Content = "<script>alert('YASAK! FireFox veya Chrome kullanın.');</script>" };

            base.OnActionExecuting(filterContext);
        }
        /// <summary>
        /// Action metod tetiklendikten sonra ActionResult tipinde sonuç döndükten sonra devreye giren metod.
        /// </summary>
        /// <param name="filterContext"></param>
        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            filterContext.HttpContext.Response.AddHeader("Cache-Control", "private, max-age=0");
            base.OnResultExecuted(filterContext);
        }
        /// <summary>
        /// OnResultExecuting: Action metod tetiklendikten sonra ActionResult tipinde sonuç döndürülmeden önce devreye giren metod.
        /// </summary>
        /// <param name="filterContext"></param>
        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            base.OnResultExecuting(filterContext);
        }
    }
}