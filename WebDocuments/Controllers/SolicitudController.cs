using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using System.IO;

namespace WebDocuments.Controllers
{
    public class SolicitudController : Controller
    {
        // GET: Solicitud
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult UploadFile()
        {
            return View();
        }

        public ActionResult UploadFile(HttpPostedFileBase file)
        {
            try
            {
                if (file.ContentLength > 0)
                {
                    string _FileName = Path.GetFileName(file.FileName);
                    string _path = Path.Combine(Server.MapPath("~/Documento"), _FileName);
                    file.SaveAs(_path);
                }
                ViewBag.Message = "Documento cargado correctamente!";
                return View();
            }
            catch(Exception ex)
            {
                ViewBag.Message = "Falló carga de documento!";
                return View();
            }
        }
    }
}