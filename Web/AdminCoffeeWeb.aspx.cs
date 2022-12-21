using Business.Abstract;
using Business.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web
{
    public partial class AdminCoffeeWeb : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_Add_Click(object sender, EventArgs e)
        {
            Coffee coffee = new Coffee();
            coffee.CategoryId = Convert.ToInt32(tbx_CategoryId.Text);
            coffee.Name = tbx_Name.Text;
            coffee.UnitPrice = Convert.ToDecimal(tbx_UnitPrice.Text);
            coffee.UnitsInStock = Convert.ToInt32(tbx_UnitsInStock.Text);

            ICoffeeService coffeeService = new CoffeeManager();
            coffeeService.add(coffee);
        }
    }
}