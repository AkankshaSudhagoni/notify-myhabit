using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HabitApp.Models;
using HabitApp.Services.Implementations;
using HabitApp.Services.Interfaces;
using HabitApp.Utils;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HabitApp.Pages
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        public LoginCredentialsModel LoginCredentials { get; set; }

        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            ILogin loginService = new LoginImpl();

            LoginDataModel loginData = new LoginDataModel();

            loginData.Email = LoginCredentials.Email;
            loginData.Password = Hashing.Base64Encode(LoginCredentials.Password);


            LoginSucessDTO postLogin = loginService.login(loginData);

            if (postLogin.LoginStatus)
            {
                //if login is sucessfull set status code and email and id to store in cache
                ViewData["LoginStatus"] = string.Format("200");
                ViewData["Email"] = string.Format(loginData.Email);
                String id = postLogin.UserId.ToString();
                ViewData["Id"] = string.Format(id);
                

            }
            else
            {
                //prepare the error message
                ViewData["LoginStatus"] = string.Format("500");
                ViewData["Message"] = string.Format("Login Failed Please try again!");
            }

            return null;
        }
    }
}
