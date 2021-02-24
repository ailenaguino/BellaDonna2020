using Repositories;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web.Controllers
{
    public class TratamientosController : Controller
    {
        TratamientoService tratamientoService;
        PromoService promoService;

        public TratamientosController()
        {
            Contexto contexto = new Contexto();
            tratamientoService = new TratamientoService(contexto);
            promoService = new PromoService(contexto);
        }

        public ActionResult listarTratamientos()
        {
            var tratamientos = tratamientoService.ObtenerTodos();
            return View(tratamientos);
        }

        public ActionResult listarPromos()
        {
            var promos = promoService.ObtenerTodos();
            return View();
        }

        [HttpGet]
        public ActionResult getTratamiento(int id)
        {
            var tratamiento = tratamientoService.ObtenerPorId(id);
            return View(tratamiento);
        }

        public ActionResult galery()
        {
            return View();
        }
    }
}