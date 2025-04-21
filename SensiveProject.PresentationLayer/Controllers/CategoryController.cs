using Microsoft.AspNetCore.Mvc;
using SensiveProject.BusinessLayer.Abstract;
using System.Drawing.Printing;

namespace SensiveProject.PresentationLayer.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public IActionResult CategoryList()
        {
            var values = _categoryService.TGetAll();
            return View(values);
        }
    }
}
