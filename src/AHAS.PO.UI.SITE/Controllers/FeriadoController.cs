using AHAS.PO.INFRA.CROSS.GLOBALIZING;
using AHAS.PO.SERVICE.APPLICATION.Interfaces;
using AHAS.PO.SERVICE.APPLICATION.ViewModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace AHAS.PO.UI.SITE.Controllers
{
    public class FeriadoController : Controller
    {
        private readonly IFeriadoAppService _FeriadoAppService;
        private readonly IEstadoAppService _EstadoAppService;
        private readonly IAbrangenciaAppService _AbrangenciaAppService;

        public FeriadoController(IFeriadoAppService feriadoAppService, IAbrangenciaAppService abrangenciaAppService, IEstadoAppService estadoAppService)
        {
            _FeriadoAppService = feriadoAppService;
            _EstadoAppService = estadoAppService;
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
            FeriadoViewModel viewModel = new FeriadoViewModel
            {
                ListaAbrangencia = _AbrangenciaAppService.Listar(),
                ListaEstado = _EstadoAppService.Listar()
            };

            return View(viewModel);
        }

        // POST: Feriados/Create
        [HttpPost]
        public ActionResult Adicionar(FeriadoViewModel feriadoViewModel)
        {
            feriadoViewModel.ListaAbrangencia = _AbrangenciaAppService.Listar();
            feriadoViewModel.ListaEstado = _EstadoAppService.Listar();

            if (ModelState.IsValid)
            {
                feriadoViewModel = _FeriadoAppService.Inserir(feriadoViewModel);

                if (!feriadoViewModel.Sucesso)
                {
                    foreach (var item in feriadoViewModel.MensagemValidacao)
                    {
                        ModelState.AddModelError(string.Empty, item);
                    }

                    return View(feriadoViewModel);
                }

                foreach (var item in feriadoViewModel.MensagemValidacao)
                {
                    TempData["sucesso"] = item;
                }

                return RedirectToAction("Index");
            }

            return View(feriadoViewModel);
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
