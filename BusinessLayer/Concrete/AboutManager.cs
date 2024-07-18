using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class AboutManager : IAboutService
    {
        IAboutDal _iaboutdal;

        public AboutManager(IAboutDal iaboutdal)
        {
            _iaboutdal = iaboutdal;
        }

        public void Delete(About t)
        {
            _iaboutdal.Delete(t);
        }

        public About GetById(int id)
        {
          return  _iaboutdal.GetById(id);
        }

        public List<About> GetListAll()
        {
            return _iaboutdal.GetListAll();
        }

        public void Insert(About t)
        {
            _iaboutdal.Insert(t);
        }

        public void Update(About t)
        {
            _iaboutdal.Update(t);
        }
    }
}
