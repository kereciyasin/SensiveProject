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
    public class ContactManager : IContactService
    {
        private readonly IContactDal _contactDal;

        public ContactManager(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }

        public List<Contact> GetAll()
        {
            return _contactDal.GetAll();
        }

        public Contact GetById(int id)
        {
            return _contactDal.GetById(id);
        }

        public void TDelete(int id)
        {
            _contactDal.TDelete(id);
        }

        public List<Contact> TGetAll()
        {
            return _contactDal.GetAll();
        }

        public void TInsert(Contact entity)
        {
            _contactDal.TInsert(entity);
        }

        public void TUpdate(Contact entity)
        {
            _contactDal.TUpdate(entity);
        }
    }

}
