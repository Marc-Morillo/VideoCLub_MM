using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MiVideoClub.Models;
using MiVideoClub.Controllers;

namespace MiVideoClub.Filters
{
  public class VerifySession : ActionFilterAttribute
  {
    public override void OnActionExecuting(ActionExecutingContext filterContext)
    {
      var oUser = (Empleados)HttpContext.Current.Session["User"];
      if(oUser == null)
      {
        if(filterContext.Controller is AccessController == false)
        {
          filterContext.HttpContext.Response.Redirect("~/Access/Index");
        }
      }
      else
      {
        if (filterContext.Controller is AccessController == true)
        {
          filterContext.HttpContext.Response.Redirect("~/Home/Index");
        }
      }

      base.OnActionExecuting(filterContext);
    }
  }
}