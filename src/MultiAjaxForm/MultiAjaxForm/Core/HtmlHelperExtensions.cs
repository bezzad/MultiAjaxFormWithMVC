using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace MultiAjaxForm.Core
{
    public static class HtmlHelperExtensions
    {
        private static int _counter = 1;
        public static MvcHtmlString GetNewNo(this HtmlHelper html)
        {
            return new MvcHtmlString(_counter++.ToString());
        }
    }
}
