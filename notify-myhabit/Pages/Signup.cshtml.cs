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
    public class SignupModel : PageModel
    {
        [BindProperty]
        public SignUpDataModel SignUpdata { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {

            if (SignUpdata.Password.Equals(SignUpdata.ConfirmPassword))
            {
                ISignUp signUpService = new SignUpImpl();

                UserModel user = new UserModel();

                user.Email = SignUpdata.Email;
                user.FullName = SignUpdata.FullName;
                user.Password = Hashing.Base64Encode(SignUpdata.Password);

                bool isSucess = signUpService.signUp(user);

                if (isSucess)
                {
                    return RedirectToPage("index");
                }
            }
            else 
            {
                ViewData["Message"] = string.Format("Passwords Dose Not Match!");
            }

           

            return null;
        }
    }
}
