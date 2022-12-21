using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICoffeeService
    {
        List<Coffee> GetAll();
        List<CoffeeDto> GetAllByDto();
        Coffee GetById(int id);
        void add(Coffee coffee);
        void Delete(Coffee coffee);
        void Update(Coffee coffee);
    }
}
