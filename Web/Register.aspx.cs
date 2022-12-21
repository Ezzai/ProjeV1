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
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btn_Register_Click(object sender, EventArgs e)
        {
            UserForRegisterDto userForRegisterDto = new UserForRegisterDto();
            userForRegisterDto.FirstName = tbx_FirstName.Text;
            userForRegisterDto.LastName = tbx_LastName.Text;
            userForRegisterDto.Email = tbx_Email.Text;
            userForRegisterDto.Password = tbx_Password.Text;
            userForRegisterDto.PhoneNumber = tbx_PhoneNumber.Text;
            userForRegisterDto.Address = tbx_Address.Text;

            IAuthService authService = new AuthManager();
            authService.Register(userForRegisterDto);

            Response.Redirect("~/Login.aspx");
        }
    }
}