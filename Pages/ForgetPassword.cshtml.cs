using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using HabitApp.Models;
using HabitApp.Services.Implementations;
using HabitApp.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HabitApp.Pages
{
    public class ForgetPasswordModel : PageModel
    {   [BindProperty]
        public ForgotDataModel ForgotModel { get; set; }
        public void OnGet()
        {

        }

        public IActionResult OnPost() 
        {

            //create a random number between 1000 to 9999 and email it to the user. 
            //after the sending the email save the email and the relevent password in the database
            Random myObject = new Random();
            int rand = myObject.Next(1000, 9999);

            MailMessage message = new MailMessage();
            SmtpClient smtp = new SmtpClient();
            message.From = new MailAddress("habitapp863@gmail.com");
            message.To.Add(new MailAddress(ForgotModel.Email));
            message.Subject = "Rest Password";
            message.IsBodyHtml = true; //to make message body as html  
            message.Body = "Your Code is " + rand;
            smtp.Port = 587;
            smtp.Host = "smtp.gmail.com"; //for gmail host  
            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential("habitapp863@gmail.com", "habit123#");
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Send(message);

            IForgotPassword forgotPasswordService = new ForgotPasswordImpl();

            ForgotModel.Code = rand.ToString();


            forgotPasswordService.forgotPassword(ForgotModel);

            return RedirectToPage("resetpassword");
        }
    }
}
