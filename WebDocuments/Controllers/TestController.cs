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
            TestModel model = new TestModel();

            using(ServiceUsuario.UsuarioServiceClient svc = new UsuarioServiceClient())
            {
                model.Message = svc.SayHello("Paul");
            }

            return View(model);
        }
    }
}