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
    public class ServiceManager : IServiceService
    {
        private readonly IServiceDal serviceDal;

        public ServiceManager(IServiceDal serviceDal)
        {
            this.serviceDal = serviceDal;
        }

        public void Delete(Service t)
        {
            serviceDal.Delete(t);
        }

        public Service GetById(int id)
        {
            return serviceDal.GetById(id);
        }

        public List<Service> GetListAll()
        {
            return serviceDal.GetListAll();
        }

        public void Insert(Service t)
        {
            serviceDal.Insert(t);
        }

        public void Update(Service t)
        {
            serviceDal.Update(t);
        }
    }
}
