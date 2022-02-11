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
    public class AdminLoginModel : PageModel
    {
        [BindProperty]
        public LoginCredentialsModel LoginCredentials { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            ILogin loginService = new AdminLoginImpl();

            LoginDataModel adminLoginData = new LoginDataModel();

            adminLoginData.Email = LoginCredentials.Email;
            adminLoginData.Password =Hashing.Base64Encode(LoginCredentials.Password);


            LoginSucessDTO postLogin = loginService.login(adminLoginData);

            if (postLogin.LoginStatus)
            {

                ViewData["LoginStatus"] = string.Format("200");
                ViewData["Email"] = string.Format(adminLoginData.Email);
                ViewData["Role"] = string.Format("Admin");
                String id = postLogin.UserId.ToString();
                ViewData["Id"] = string.Format(id);

            }
            else
            {
                ViewData["LoginStatus"] = string.Format("500");
                //ViewData["Message"] = string.Format("Login Failed Please try again!");
            }

            return null;
        }
    }
}
