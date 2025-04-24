using Microsoft.AspNetCore.Mvc;
using SensiveProject.BusinessLayer.Abstract;

namespace SensiveProject.PresentationLayer.Controllers
{
    public class ArtikelController : Controller
    {
        private readonly IArtikelService _artikelService;

        public ArtikelController(IArtikelService artikelService)
        {
            _artikelService = artikelService;
        }

        public IActionResult ArtikelList()
        {
            var values = _artikelService.TGetAll();
            return View(values);
        }

        public IActionResult ArtikelListWithCategory()
        {
            var values = _artikelService.TArtikelListWithCategory();
            return View(values);
        }
    }
}
