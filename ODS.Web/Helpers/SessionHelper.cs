using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ODS.Web.Helpers
{
    public class SessionHelper
    {
        public static int UserId
        {
            get
            {
                return HttpContext.Current.Session["UserId"] == null ? 0 : (int)HttpContext.Current.Session["UserId"];
            }
            set
            {
                HttpContext.Current.Session["UserId"] = value;
            }
        }

    }
}