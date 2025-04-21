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
            throw new NotImplementedException();
        }

        public Category GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void TDelete(int id)
        {
            throw new NotImplementedException();
        }

        public void TInsert(Category entity)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Category entity)
        {
            throw new NotImplementedException();
        }
    }
}
