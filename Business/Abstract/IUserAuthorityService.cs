using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IUserAuthorityService
    {
        List<UserAuthority> GetAll();
        UserAuthority GetUserAuthority(User user);
        UserAuthority GetById(int id);
        void add(UserAuthority userAuthority);
        void Delete(UserAuthority userAuthority);
        void Update(UserAuthority userAuthority);
    }
}
