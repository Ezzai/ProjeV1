using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dtos
{
    public class UserAuthoritiesDto
    {
        public User User { get; set; }
        public AuthorityDto Authority { get; set; }
    }
}
