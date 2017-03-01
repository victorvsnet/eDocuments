using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using WebDocuments.Models;

namespace WebDocuments.Controllers
{
    public class SolicitudController : Controller
    {
        // GET: Solicitud
        public ActionResult Index()
        {
            List<EstadoModel> model = new List<EstadoModel>();
            using (ServiceGeneral.GeneralServiceClient svc = new ServiceGeneral.GeneralServiceClient())
            {
                var lstEstados = svc.ListarEstado();
                foreach(var item in lstEstados)
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