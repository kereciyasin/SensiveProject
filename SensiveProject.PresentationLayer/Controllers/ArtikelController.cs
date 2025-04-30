using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SensiveProject.BusinessLayer.Abstract;

namespace SensiveProject.PresentationLayer.Controllers
{
    public class ArtikelController : Controller
    {
        private readonly IArtikelService _artikelService;

        private readonly ICategoryService _categoryService;

        private readonly IAppUserService _appUserService;

        public ArtikelController(IArtikelService artikelService, ICategoryService categoryService, IAppUserService appUserService)
        {
            _artikelService = artikelService;
            _categoryService = categoryService;
            _appUserService = appUserService;
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

            var appUserList = _appUserService.TGetAll();
            List<SelectListItem> values2 = (from x in appUserList
                                            select new SelectListItem
                                            {
                                                Text = x.Name + " " + x.Surname,
                                                Value = x.Id.ToString()
                                            }).ToList();
            ViewBag.v2 = values2;


            return View();
        }
    }
}
