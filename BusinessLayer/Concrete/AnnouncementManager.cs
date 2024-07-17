using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class AnnouncementManager : IAnnouncementService
    {
        IAnnouncementDal _idal;

        public AnnouncementManager(IAnnouncementDal idal)
        {
            _idal = idal;
        }

        public void ChangeStatus(int id)
        {
            Announcement a = _idal.GetById(id);
            if (a.Status == true)
            {
                a.Status = false;
                _idal.Update(a);
            }
            else
            {
                a.Status = true;
                _idal.Update(a);
            }
        }

        public void Delete(Announcement t)
        {
            _idal.Delete(t);
        }

        public Announcement GetById(int id)
        {
            return _idal.GetById(id);
        }

        public List<Announcement> GetListAll()
        {
            return _idal.GetListAll();
        }

        public void Insert(Announcement t)
        {
            _idal.Insert(t);
        }

        public void Update(Announcement t)
        {
            _idal.Update(t);
        }
    }
}
