using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class AuthManager : IAuthService
    {
        private IUserService _userService;
        private IUserAuthorityService _userAuthorityService;
        private IAuthorityService _authorityService;
        public AuthManager()
        {
            _userService = new UserManager();
            _userAuthorityService = new UserAuthorityManager();
            _authorityService = new AuthorityManager();
        }

        public string GetAuthority(UserAuthoritiesDto userAuthoritiesDto)
        {
            if (userAuthoritiesDto.Authority.AuthorityName == null)
            {
                return null;
            }

            return userAuthoritiesDto.Authority.AuthorityName;
        }

        public UserAuthoritiesDto GetUserAuthority(User user)
        {
            var result = _userAuthorityService.GetUserAuthority(user);
            var authority = _authorityService.GetById(result.AuthorityId);

            AuthorityDto authorityDto = new AuthorityDto();
            authorityDto.AuthorityId = authority.Id;
            authorityDto.AuthorityName = authority.Name;

            UserAuthoritiesDto userAuthoritiesDto = new UserAuthoritiesDto();
            userAuthoritiesDto.User = user;
            userAuthoritiesDto.Authority = authorityDto;

            return userAuthoritiesDto;
        }

        public User Login(UserForLoginDto userForLoginDto)
        {
            var userToCheck = _userService.GetByMail(userForLoginDto.Email);

            if (userToCheck.Password != userForLoginDto.Password)
            {
                return null;
            }

            return userToCheck;
        }

        public void Register(UserForRegisterDto userForRegisterDto)
        {
            var userToCheck = _userService.GetByMail(userForRegisterDto.Email);

            User user = new User
            {
                FirstName = userForRegisterDto.FirstName,
                LastName = userForRegisterDto.LastName,
                Email = userForRegisterDto.Email,
                Password = userForRegisterDto.Password,
            };
            _userService.Add(user);
        }

        public bool UserExists(string email)
        {
            var userExist = _userService.GetByMail(email);
            if (userExist != null)
            {
                return false;
            }
            return true;
        }
    }
}
