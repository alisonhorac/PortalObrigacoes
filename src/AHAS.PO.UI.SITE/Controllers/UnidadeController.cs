using AHAS.PO.SERVICE.APPLICATION.Interfaces;
using AHAS.PO.SERVICE.APPLICATION.ViewModels;
using AHAS.PO.UI.SITE.Helper;
using System.Web.Mvc;

namespace AHAS.PO.UI.SITE.Controllers
{
    public class UnidadeController : Controller
    {
        private readonly IUnidadeAppService _UnidadeAppService;

        public UnidadeController(IUnidadeAppService UnidadeAppService)
        {
            _UnidadeAppService = UnidadeAppService;
        }

        // GET: Unidade
        [HttpGet]
        public ActionResult Index()
        {
            return View(_UnidadeAppService.Listar());
        }

        // GET: Unidade/Detalhar/5
        [HttpGet]
        public ActionResult Detalhar(int id)
        {
            UnidadeViewModel viewModel = _UnidadeAppService.Consultar(id);

            if (viewModel == null)
            {
                return HttpNotFound();
            }

            return View(viewModel);
        }

        // GET: Unidade/Adicionar
        [HttpGet]
        public ActionResult Adicionar()
        {
            UnidadeViewModel viewModel = new UnidadeViewModel();

            return View(viewModel);
        }

        // POST: Unidade/Adicionar
        [HttpPost]
        public ActionResult Adicionar(UnidadeViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                viewModel = _UnidadeAppService.Inserir(viewModel);

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

        // GET: Unidade/Editar/5
        [HttpGet]
        public ActionResult Editar(long id)
        {
            UnidadeViewModel viewModel = _UnidadeAppService.Consultar(id);

            if (viewModel == null)
            {
                return HttpNotFound();
            }

            return View(viewModel);
        }

        // POST: Unidade/Editar/5
        [HttpPost]
        public ActionResult Editar(UnidadeViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                viewModel = _UnidadeAppService.Alterar(viewModel);

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
                Sucess = _UnidadeAppService.Excluir(id)
            };

            return Json(resultado);
        }
    }
}
