using SensiveProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensiveProject.DataAccesLayer.Abstract
{
    public interface IArtikelDal : IGenericDal<Artikel>
    {
        List<Artikel> ArtikelListWithCategory();
        List<Artikel> ArtikelListWithCategoryAndAppUser();
    }
}
