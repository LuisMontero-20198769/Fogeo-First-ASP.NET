using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Vistas.Controllers
{
    public class WelcomeController : Controller
    {
        // GET: Welcome
        public ActionResult Inicio()
        {
            //Bienvenida: Nombre de la App y Foto del ITLA
            return View();
        }

        public ActionResult Pilares()
        {
            //Explicacion de los pilares de la programacion
            return View();
        }

        public ActionResult Bosquejo()
        {
            return View();
        }

        public ActionResult Estudiante()
        {
            //Datos de Luis Angel Montero
            return View();
        }   
    }
}