using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class AuthorityManager : IAuthorityService
    {
        IAuthorityDal _authorityDal;

        public AuthorityManager()
        {
            _authorityDal = new EfAuthorityDal();
        }

        public void add(Authority authority)
        {
            _authorityDal.Add(authority);
        }

        public void Delete(Authority authority)
        {
            _authorityDal.Delete(authority);
        }

        public List<Authority> GetAll()
        {
            return _authorityDal.GetAll();
        }

        public Authority GetById(int id)
        {
            return _authorityDal.Get(a => a.Id == id);
        }

        public void Update(Authority authority)
        {
            _authorityDal.Update(authority);
        }
    }
}
