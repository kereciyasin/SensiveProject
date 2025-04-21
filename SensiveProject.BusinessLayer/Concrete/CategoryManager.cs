using SensiveProject.BusinessLayer.Abstract;
using SensiveProject.DataAccesLayer.Abstract;
using SensiveProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensiveProject.BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService

    {
        private readonly ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public List<Category> GetAll()
        {
            return _categoryDal.GetAll();
        }

        public Category GetById(int id)
        {
            return _categoryDal.GetById(id);
        }

        public void TDelete(int id)
        {
            _categoryDal.Delete(id);
        }

        public void TInsert(Category entity)
        {
            if (entity.CategoryName.Length >= 5 && entity.CategoryName.Length <= 50)
            {
                _categoryDal.Insert(entity);
            }
            else
            {
                throw new Exception("Category name must be between 5 and 50 characters.");
            }
        }

        public void TUpdate(Category entity)
        {
            _categoryDal.Update(entity);
        }
    }
}
