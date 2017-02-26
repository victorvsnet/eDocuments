using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using WebDocuments.Models;
using WebDocuments.ServiceUsuario;


namespace WebDocuments.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Index2()
        {
            using (ServiceGeneral.GeneralServiceClient svc = new ServiceGeneral.GeneralServiceClient())
            {
                var lista = svc.ListarEstado();
            }

            return View();
        }
    }
}