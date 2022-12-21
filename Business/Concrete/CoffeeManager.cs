using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CoffeeManager : ICoffeeService
    {
        ICoffeeDal _coffeeDal;

        public CoffeeManager()
        {
            _coffeeDal = new EfCoffeeDal();
        }

        public void add(Coffee coffee)
        {
            _coffeeDal.Add(coffee);
        }

        public void Delete(Coffee coffee)
        {
            _coffeeDal.Delete(coffee);
        }

        public List<Coffee> GetAll()
        {
            return _coffeeDal.GetAll();
        }

        public List<CoffeeDto> GetAllByDto()
        {
            return _coffeeDal.GetCoffeeDtos();
        }

        public Coffee GetById(int id)
        {
            return _coffeeDal.Get(c => c.Id == id);
        }

        public void Update(Coffee coffee)
        {
            _coffeeDal.Update(coffee);
        }
    }
}
