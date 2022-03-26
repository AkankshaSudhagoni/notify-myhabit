using HabitApp.DBHandler.Childerns;
using HabitApp.Models;
using HabitApp.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HabitApp.Services.Implementations
{
    public class SignUpImpl : ISignUp
    {
        public bool signUp(UserModel user)
        {
            bool isFullNameValid = !String.IsNullOrEmpty(user.FullName);
            bool isEmailValid = !String.IsNullOrEmpty(user.Email);
            bool isPasswordValid = false;

            if (user.Password.Length > 0)
            {
                isPasswordValid = true;
            }

             bool isSucess  = false;

            if (isFullNameValid && isEmailValid && isPasswordValid) 
            {
                SignUpDataHandler dbhandler = new SignUpDataHandler("habbitCollection");

                bool status = dbhandler.SignUp(user).Result;


                if (status)
                {
                    isSucess = status;
                }
            }

            return isSucess;

        }
    }
}
