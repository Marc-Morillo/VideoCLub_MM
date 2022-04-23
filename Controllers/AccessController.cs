using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MiVideoClub.Models;

namespace MiVideoClub.Controllers
{
    public class AccessController : Controller
    {
        // GET: Access
        public ActionResult Index()
        {
            return View();
        }

      public ActionResult Enter(string user, string password)
      {
          try
          {
            using (VideoClubEntities db = new VideoClubEntities())
            {
              var ls = from d in db.Empleados
                       where d.NombreUsuario == user && d.Contrasena == password && d.idEstado == 1
                       select d;
              if(ls.Count() > 0)
              {
                Empleados oUser = ls.First();
                Session["User"] = oUser;
                return Content("1");
              }
              else
              {
                return Content("Usuario Invalido :(");
              }
            }    
          }
          catch(Exception ex)
          {
            return Content("Ocurrio un error T_T " + ex.Message);
          }
      }
    }
}