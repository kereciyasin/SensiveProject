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
    public class ArtikelManager : IArtikelService
    {
        private readonly IArtikelDal _artikelDal;

        public ArtikelManager(IArtikelDal artikelDal)
        {
            _artikelDal = artikelDal;
        }

        public List<Artikel> GetAll()
        {
            return _artikelDal.GetAll();
        }

        public Artikel GetById(int id)
        {
            return _artikelDal.GetById(id);
        }

        public void TDelete(int id)
        {
            _artikelDal.Delete(id);
        }

        public List<Artikel> TGetAll()
        {
            return _artikelDal.GetAll();
        }

        public void TInsert(Artikel entity)
        {
            _artikelDal.Insert(entity);
        }

        public void TUpdate(Artikel entity)
        {
            if (entity.Description != "" && entity.ArtikelTitle.Length >= 5 && entity.ArtikelTitle.Length <= 100)
            {
                _artikelDal.Update(entity);
            }
            else
            {
                // throw new Exception("Lütfen 5 ile 100 karakter arasında bir başlık giriniz.");
            }
        }
    }
}
