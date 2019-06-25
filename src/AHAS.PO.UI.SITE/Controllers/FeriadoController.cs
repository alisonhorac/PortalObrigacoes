using AHAS.PO.SERVICE.APPLICATION.Interfaces;
using AHAS.PO.SERVICE.APPLICATION.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AHAS.PO.UI.SITE.Controllers
{
    public class FeriadoController : Controller
    {
        private readonly IFeriadoAppService _FeriadoAppService;
        private readonly IAbrangenciaAppService _AbrangenciaAppService;

        public FeriadoController(IFeriadoAppService feriadoAppService, IAbrangenciaAppService abrangenciaAppService)
        {
            _FeriadoAppService = feriadoAppService;
            _AbrangenciaAppService = abrangenciaAppService;
        }

        // GET: Feriados
        [HttpGet]
        public ActionResult Index()
        {
            return View(_FeriadoAppService.Listar());
        }

        // GET: Feriados/Details/5
        [HttpGet]
        public ActionResult Detalhar(int id)
        {
            return View();
        }

        // GET: Feriados/Create
        [HttpGet]
        public ActionResult Adicionar()
        {
            ViewBag.ListaAbrangencia = new SelectList(_AbrangenciaAppService.Listar(), "IDAbrangencia", "Descricao");
            return View();
        }

        // POST: Feriados/Create
        [HttpPost]
        public ActionResult Adicionar(FeriadoViewModel feriadoViewModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    feriadoViewModel = _FeriadoAppService.Inserir(feriadoViewModel);

                    return RedirectToAction("Index");
                }

                return View(feriadoViewModel);
            }
            catch
            {
                return View();
            }
        }

        // GET: Feriados/Edit/5
        [HttpGet]
        public ActionResult Editar(Guid? id)
        {
            return View();
        }

        // POST: Feriados/Edit/5
        [HttpPost]
        public ActionResult Editar(FeriadoViewModel feriadoViewModel)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Feriados/Delete/5
        [HttpGet]
        public ActionResult Excluir(Guid? id)
        {
            return View();
        }

        // POST: Feriados/Delete/5
        [HttpPost]
        public ActionResult Excluir(Guid id)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _FeriadoAppService.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
