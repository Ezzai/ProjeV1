using Business.Abstract;
using Business.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_login_Click(object sender, EventArgs e)
        {
            UserForLoginDto userForLoginDto = new UserForLoginDto();
            userForLoginDto.Email = tbx_Email.Text;
            userForLoginDto.Password = tbx_Password.Text;

            
            IAuthService authService = new AuthManager();
            var user = authService.Login(userForLoginDto);

            var authority =  authService.GetUserAuthority(user);
            var userAuth = authService.GetAuthority(authority);

            if (userAuth == "Admin" || userAuth == "admin")
            {
                Response.Redirect("~/AdminCoffeeWeb.aspx");
            }
            else
            {
                Response.Redirect("~/CoffeeWeb.aspx");
            }

        }
    }
}