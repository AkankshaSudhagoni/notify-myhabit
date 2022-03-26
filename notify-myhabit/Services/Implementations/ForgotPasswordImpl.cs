using HabitApp.DBHandler.Childerns;
using HabitApp.Models;
using HabitApp.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HabitApp.Services.Implementations
{
    public class ForgotPasswordImpl : IForgotPassword
    {
        //call method to stroe the email and code combination
        public bool forgotPassword(ForgotDataModel forgotDataModel)
        {
            ForgotPasswordDataHandler datahandler = new ForgotPasswordDataHandler("forgotpassword");

            bool status = datahandler.ForgotPassward(forgotDataModel).Result;

            return status;
        }
    }
}
