using AHAS.PO.INFRA.CROSS.GLOBALIZING;
using AHAS.PO.SERVICE.APPLICATION.Interfaces;
using AHAS.PO.SERVICE.APPLICATION.ViewModels;
using AHAS.PO.UI.SITE.Helper;
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

        // GET: Feriado
        [HttpGet]
        public ActionResult Index()
        {
            return View(_FeriadoAppService.Listar());
        }

        // GET: Feriado/Detalhar/5
        [HttpGet]
        public ActionResult Detalhar(int id)
        {
            FeriadoViewModel feriadoViewModel = _FeriadoAppService.Consultar(id);

            if (feriadoViewModel == null)
            {
                return HttpNotFound();
            }

            return View(feriadoViewModel);
        }

        // GET: Feriado/Adicionar
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

        // POST: Feriado/Adicionar
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

        // GET: Feriado/Editar/5
        [HttpGet]
        public ActionResult Editar(int id)
        {
            FeriadoViewModel feriadoViewModel = _FeriadoAppService.Consultar(id);

            if (feriadoViewModel == null)
            {
                return HttpNotFound();
            }

            feriadoViewModel.ListaAbrangencia = _AbrangenciaAppService.Listar();
            feriadoViewModel.ListaEstado = _EstadoAppService.Listar();
            
            return View(feriadoViewModel);
        }

        // POST: Feriado/Editar
        [HttpPost]
        public ActionResult Editar(FeriadoViewModel feriadoViewModel)
        {
            feriadoViewModel.ListaAbrangencia = _AbrangenciaAppService.Listar();
            feriadoViewModel.ListaEstado = _EstadoAppService.Listar();

            if (ModelState.IsValid)
            {
                feriadoViewModel = _FeriadoAppService.Alterar(feriadoViewModel);

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

        // POST: Feriado/Excluir/5
        [HttpPost]
        public ActionResult Excluir(int id)
        {
            var resultado = new ResultHelper
            {
                Sucess = _FeriadoAppService.Excluir(id)
            };

            return Json(resultado);
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
