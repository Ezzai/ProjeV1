using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class UserAuthority : IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }

        private int authorityId;
        public int AuthorityId
        {
            get { return authorityId; }
            set
            {
                if (value <1 || value > 3)
                {
                    authorityId = 1;
                }
                else
                {
                    authorityId = value;
                }
            }
        }
    }
}
