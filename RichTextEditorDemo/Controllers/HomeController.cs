using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RichTextEditorDemo.scripts;

namespace RichTextEditorDemo.Controllers
{
    public class HomeController : Controller
    {
        //Acción para mostrar el editor TinyMCE
        public ActionResult Index()
        {
            return View();
        }

        //Acción para aceptar contenido HTML
        [HttpPost]

        public ActionResult Index(EjemploEditor modelo)
        {
            return View(modelo);
        }
    }
}