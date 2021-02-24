using Repositories;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        TratamientoService tratamientoService;
        PromoService promoService;

        public HomeController()
        {
            Contexto contexto = new Contexto();
            tratamientoService = new TratamientoService(contexto);
            promoService = new PromoService(contexto);
        }

        // GET: Home
        public ActionResult Index()
        {
            var tratamientos = tratamientoService.ObtenerTodos();
            var promos = promoService.ObtenerTodos();

            return View(tratamientos);
        }

        public ActionResult About()
        {
            return View();
        }
    }
}