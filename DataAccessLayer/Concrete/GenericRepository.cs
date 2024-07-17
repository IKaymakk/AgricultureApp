using DataAccessLayer.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class GenericRepository<T> : IGenericDal<T> where T : class, new()
    {
        AgricultureContext c = new AgricultureContext();
        DbSet<T> _object;

        public GenericRepository()
        {
            _object = c.Set<T>();
        }

        public void Delete(T t)
        {
            _object.Remove(t);
            c.SaveChanges();
        }

        public T GetById(int id)
        {
            return _object.Find(id);
        }

        public List<T> GetListAll()
        {
            return _object.ToList();
        }

        public void Insert(T t)
        {
            _object.Add(t);
            c.SaveChanges();
        }

        public void Update(T t)
        {
            _object.Update(t);
            c.SaveChanges();
        }
    }
}
