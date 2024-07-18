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
    public class AdminManager : IAdminService
    {
        IAdminDal _dal;

        public AdminManager(IAdminDal dal)
        {
            _dal = dal;
        }

        public void Delete(Admin t)
        {
            _dal.Delete(t);
        }

        public Admin GetById(int id)
        {
            return _dal.GetById(id);
        }

        public List<Admin> GetListAll()
        {
            return _dal.GetListAll();
        }

        public void Insert(Admin t)
        {
            _dal.Insert(t);
        }

        public void Update(Admin t)
        {
            _dal.Update(t);
        }
    }
}
