using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Coffee : IEntity
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }

        private decimal unitPrice;
        public decimal UnitPrice
        {
            get { return unitPrice; }
            set
            {
                if (value <= 0)
                {
                    unitPrice = 10;
                }

                else
                {
                    unitPrice = value;
                }
            }
        }
        public int UnitsInStock { get; set; }
    }
}
