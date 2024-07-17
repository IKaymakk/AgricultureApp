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
    public class AddressManager : IAddressService
    {
        IAddressDal _iaddressdal;

        public AddressManager(IAddressDal iaddressdal)
        {
            _iaddressdal = iaddressdal;
        }

        public void Delete(Address t)
        {
            throw new NotImplementedException();
        }

        public Address GetById(int id)
        {
            return _iaddressdal.GetById(id);
        }

        public List<Address> GetListAll()
        {
            return _iaddressdal.GetListAll();
        }

        public void Insert(Address t)
        {
            throw new NotImplementedException();
        }

        public void Update(Address t)
        {
            _iaddressdal.Update(t);
        }
    }
}
