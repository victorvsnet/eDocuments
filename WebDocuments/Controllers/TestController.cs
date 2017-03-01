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
            List<EstadoModel> model = new List<EstadoModel>();
            using (ServiceGeneral.GeneralServiceClient svc = new ServiceGeneral.GeneralServiceClient())
            {
                var lstEstado = svc.ListarEstado();
                foreach(var item in lstEstado)
                {
                    model.Add(new EstadoModel()
                    {
                        cod_estado = item.cod_estado,
                        gls_estado = item.gls_estado
                    });
                }
            }

            return View(model);
        }
    }
}