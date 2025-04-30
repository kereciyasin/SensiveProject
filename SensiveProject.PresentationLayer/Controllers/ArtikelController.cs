using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SensiveProject.BusinessLayer.Abstract;

namespace SensiveProject.PresentationLayer.Controllers
{
    public class ArtikelController : Controller
    {
        private readonly IArtikelService _artikelService;

        private readonly ICategoryService _categoryService;

        public ArtikelController(IArtikelService artikelService, ICategoryService categoryService)
        {
            _artikelService = artikelService;
            _categoryService = categoryService;
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

        public IActionResult ArtikelListWithCategoryAndAppUser()
        {
            var values = _artikelService.TArtikelListWithCategoryAndAppUser();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateArtikel()
        {
            var categoryList = _categoryService.TGetAll();
            List<SelectListItem> values1 = (from x in categoryList
                                            select new SelectListItem
                                            {
                                                Text = x.CategoryName,
                                                Value = x.CategoryId.ToString()
                                            }).ToList();

            ViewBag.v1 = values1;
            return View();
        }
    }
}
