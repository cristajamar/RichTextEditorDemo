using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RichTextEditorDemo.scripts
{
    public class EjemploEditor
    {
        public String Titulo { get; set; }

        //Este atributo permite deshabilitar la validación de peticiones
        [AllowHtml]
        public String Contenido { get; set; }
    }
}