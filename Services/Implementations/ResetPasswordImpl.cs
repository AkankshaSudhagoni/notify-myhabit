using HabitApp.DBHandler.Childerns;
using HabitApp.Models;
using HabitApp.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HabitApp.Services.Implementations
{
    public class ResetPasswordImpl : IResetPassword
    {
        public bool ResetPassword(ResetPasswordDataModel resetPassword)
        {
            ResetPasswordDataHandler dataHandler = new ResetPasswordDataHandler("forgotpassword");

            String email = dataHandler.ResetPassword(resetPassword);

            UserDataHandler userDataHandler = new UserDataHandler("habbitCollection");

            bool status = userDataHandler.FindUserByEmailandUpdate(email, resetPassword.newPassword);

            return status;
        }
    }
}
