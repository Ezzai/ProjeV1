using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class EfCoffeeDal : EfEntityRepository<Coffee, CoffeeSellerContext>, ICoffeeDal
    {
        public List<CoffeeDto> GetCoffeeDtos()
        {
            using (CoffeeSellerContext context = new CoffeeSellerContext())
            {
                var result = from coffee in context.Coffees
                             join category in context.Categories
                             on coffee.CategoryId equals category.Id
                             select new CoffeeDto
                             {
                                 CategoryName = category.Name,
                                 Name = coffee.Name,
                                 UnitPrice = coffee.UnitPrice,
                                 UnitsInStock = coffee.UnitsInStock
                             };
                return result.ToList();
            }
        }
    }
}
