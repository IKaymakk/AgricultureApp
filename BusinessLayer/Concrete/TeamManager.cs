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
    public class TeamManager : ITeamService
    {
        private readonly ITeamDal _iteamdal;

        public TeamManager(ITeamDal iteamdal)
        {
            _iteamdal = iteamdal;
        }

        public void Delete(Team t)
        {
            _iteamdal.Delete(t);
        }

        public Team GetById(int id)
        {
            return _iteamdal.GetById(id);
        }

        public List<Team> GetListAll()
        {
            return _iteamdal.GetListAll();
        }

        public void Insert(Team t)
        {
            _iteamdal.Insert(t);
        }

        public void Update(Team t)
        {
            _iteamdal.Update(t);
        }
    }
}
