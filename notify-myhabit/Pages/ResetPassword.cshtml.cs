using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HabitApp.Models;
using HabitApp.Services.Implementations;
using HabitApp.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HabitApp.Pages
{
    public class ResetPasswordModel : PageModel
    {
        [BindProperty]
        public ResetPasswordDataModel ResetPasswordData { get; set; }
        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            IResetPassword resetPassword = new ResetPasswordImpl();
           bool status =  resetPassword.ResetPassword(ResetPasswordData);

            //validate two password and call the method
            if (ResetPasswordData.newPassword == ResetPasswordData.confirmPassword)
            {
                if (status)
                {
                    try { return RedirectToPage("index"); } catch (Exception) { ViewData["Message"] = string.Format("Something went wrong!!!"); }
                }
                else
                {
                    ViewData["Message"] = string.Format("Something went wrong!!!");
                }
            }
            else 
            {
                ViewData["Message"] = string.Format("Something went wrong!!!");
            }

            return null;
        

        }
    }
}
