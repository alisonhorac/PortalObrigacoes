using AHAS.PO.SERVICE.APPLICATION.Interfaces;
using AHAS.PO.SERVICE.APPLICATION.ViewModels;
using AHAS.PO.UI.SITE.Helper;
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
        public ActionResult Detalhar(long id)
        {
            FeriadoViewModel viewModel = _FeriadoAppService.Consultar(id);

            if (viewModel == null)
            {
                return HttpNotFound();
            }

            return View(viewModel);
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
        public ActionResult Adicionar(FeriadoViewModel viewModel)
        {
            viewModel.ListaAbrangencia = _AbrangenciaAppService.Listar();
            viewModel.ListaEstado = _EstadoAppService.Listar();

            if (ModelState.IsValid)
            {
                viewModel = _FeriadoAppService.Inserir(viewModel);

                if (!viewModel.Sucesso)
                {
                    foreach (var item in viewModel.MensagemValidacao)
                    {
                        ModelState.AddModelError(string.Empty, item);
                    }

                    return View(viewModel);
                }

                foreach (var item in viewModel.MensagemValidacao)
                {
                    TempData["sucesso"] = item;
                }

                return RedirectToAction("Index");
            }

            return View(viewModel);
        }

        // GET: Feriado/Editar/5
        [HttpGet]
        public ActionResult Editar(long id)
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
        public ActionResult Editar(FeriadoViewModel viewModel)
        {
            viewModel.ListaAbrangencia = _AbrangenciaAppService.Listar();
            viewModel.ListaEstado = _EstadoAppService.Listar();

            if (ModelState.IsValid)
            {
                viewModel = _FeriadoAppService.Alterar(viewModel);

                if (!viewModel.Sucesso)
                {
                    foreach (var item in viewModel.MensagemValidacao)
                    {
                        ModelState.AddModelError(string.Empty, item);
                    }

                    return View(viewModel);
                }

                foreach (var item in viewModel.MensagemValidacao)
                {
                    TempData["sucesso"] = item;
                }

                return RedirectToAction("Index");
            }

            return View(viewModel);
        }

        // POST: Feriado/Excluir/5
        [HttpPost]
        public ActionResult Excluir(long id)
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
