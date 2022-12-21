using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IAuthService
    {
        User Login(UserForLoginDto userForLoginDto);
        void Register(UserForRegisterDto userForRegisterDto);
        bool UserExists(string email);
        UserAuthoritiesDto GetUserAuthority(User user);
        string GetAuthority(UserAuthoritiesDto userAuthoritiesDto);
    }
}
