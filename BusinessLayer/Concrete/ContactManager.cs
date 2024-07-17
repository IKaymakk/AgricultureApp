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
    public class ContactManager : IContactService
    {
        IContactDal _contact;

        public ContactManager(IContactDal contact)
        {
            _contact = contact;
        }

        public void Delete(Contact t)
        {
            _contact.Delete(t);
        }

        public Contact GetById(int id)
        {
            return _contact.GetById(id);
        }

        public List<Contact> GetListAll()
        {
            return _contact.GetListAll();
        }

        public void Insert(Contact t)
        {
            throw new NotImplementedException();
        }

        public void Update(Contact t)
        {
            throw new NotImplementedException();
        }
    }
}
