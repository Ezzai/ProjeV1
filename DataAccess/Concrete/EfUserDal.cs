using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class EfUserDal : EfEntityRepository<User, CoffeeSellerContext>, IUserDal
    {
        public List<AuthorityDto> GetAuthorities(User user)
        {
            using (CoffeeSellerContext context = new CoffeeSellerContext())
            {
                var result = from authority in context.Authorities
                             join userAuthority in context.UserAuthorities
                             on authority.Id equals userAuthority.AuthorityId
                             where userAuthority.UserId == user.Id
                             select new AuthorityDto { AuthorityId = authority.Id, AuthorityName = authority.Name };
                return result.ToList();
            }
        }
    }
}
