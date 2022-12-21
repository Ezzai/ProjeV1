using DataAccess.Abstract;
using DataAccess.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public abstract class AbstractCustomerService
    {
        ICustomerDal _customerDal;

        protected AbstractCustomerService()
        {
            _customerDal = new EfCustomerDal();
        }

        public virtual List<Customer> GetCustomerByAges(int age = 18)
        {
            return _customerDal.GetAll(c => c.Age == age);
        }

        public virtual Customer GetCustomerByAge(int age)
        {
            return _customerDal.Get(c => c.Age == age);
        }
    }
}
