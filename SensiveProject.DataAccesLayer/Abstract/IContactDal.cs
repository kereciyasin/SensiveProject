using SensiveProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensiveProject.DataAccesLayer.Abstract
{
    public interface IContactDal : IGenericDal<Contact>
    {
        void TDelete(int id);
        void TInsert(Contact entity);
        void TUpdate(Contact entity);
    }


}
