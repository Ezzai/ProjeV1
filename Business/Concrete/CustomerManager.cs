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
    public class CustomerManager : AbstractCustomerService,ICustomerService
    {
        ICustomerDal _customerDal;

        public CustomerManager()
        {
            _customerDal = new EfCustomerDal();
        }

        public void add(Customer customer)
        {
            _customerDal.Add(customer);
        }

        public void Delete(Customer customer)
        {
            _customerDal.Delete(customer);
        }

        public List<Customer> GetAll()
        {
            return _customerDal.GetAll();
        }

        public Customer GetById(int id)
        {
            return _customerDal.Get(c => c.Id == id);
        }

        public void Update(Customer customer)
        {
            _customerDal.Update(customer);
        }

        public override List<Customer> GetCustomerByAges(int age = 18)
        {
            return base.GetCustomerByAges(age);
        }
        public override Customer GetCustomerByAge(int age)
        {
            return _customerDal.Get(c => c.Age == 30);
        }
    }
}
