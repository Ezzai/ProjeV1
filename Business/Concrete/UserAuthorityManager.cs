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
    public class UserAuthorityManager : IUserAuthorityService
    {
        IUserAuthorityDal _userAuthorityDal;

        public UserAuthorityManager()
        {
            _userAuthorityDal = new EfUserAuthorityDal();
        }

        public void add(UserAuthority userAuthority)
        {
            _userAuthorityDal.Add(userAuthority);
        }

        public void Delete(UserAuthority userAuthority)
        {
            _userAuthorityDal.Delete(userAuthority);
        }

        public List<UserAuthority> GetAll()
        {
            return _userAuthorityDal.GetAll();
        }

        public UserAuthority GetById(int id)
        {
            return _userAuthorityDal.Get(u=>u.Id == id);
        }

        public UserAuthority GetUserAuthority(User user)
        {
            return _userAuthorityDal.Get(u => u.UserId == user.Id);
        }

        public void Update(UserAuthority userAuthority)
        {
            _userAuthorityDal.Update(userAuthority);
        }
    }
}
