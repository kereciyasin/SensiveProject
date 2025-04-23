using Microsoft.EntityFrameworkCore;
using SensiveProject.DataAccesLayer.Abstract;
using SensiveProject.DataAccesLayer.Context;
using SensiveProject.DataAccesLayer.Repositories;
using SensiveProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensiveProject.DataAccesLayer.EntityFramework
{

    public class EfArtikelDal : GenericRepository<Artikel>, IArtikelDal

    {
        public EfArtikelDal(SensiveContext context) : base(context)
        {
        }

        public List<Artikel> ArtikelListWithCategory()
        {
            var context = new SensiveContext();
            var values = context.Artikels.Include(x => x.Category).ToList();
            return values;
        }
    }
}
