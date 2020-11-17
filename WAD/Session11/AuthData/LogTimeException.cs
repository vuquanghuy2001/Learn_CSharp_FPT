using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Filters;
using System.IO;

namespace Session11.AuthData
{
    public class LogTimeException:Attribute,IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext context)
        {
            //throw new NotImplementedException();
        }

        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            string message = filterContext.RouteData.Values["controller"] + " & " + filterContext.RouteData.Values["action"] + @"=OnResultExcuting " + DateTime.Now.ToString("F") + Environment.NewLine;
            Log(message);
        }

        private void Log(string message)
        {
            string path = Path.GetFullPath(@"E:\Hoc_Tap\Learn_CSharp_FPT\WAD\Session11\Content\Data.txt");
            File.AppendAllText(path, message);
        }
    }
}
