using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Customer : Person , IEntity
    {
        private int age;
        public int Age
        {
            get { return age; }
            set
            {
                if (value < 5 && value > 150)
                {
                    age = 0;
                }
                else
                {
                    age = value;
                }
            }
        }
    }
}
