using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IAuthorityService
    {
        List<Authority> GetAll();
        Authority GetById(int id);
        void add(Authority authority);
        void Delete(Authority authority);
        void Update(Authority authority);
    }
}
