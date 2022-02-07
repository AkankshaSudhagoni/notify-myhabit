using HabitApp.Models;
using HabitApp.Services.Interfaces;
using HabitApp.DBHandler.Childerns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HabitApp.Services.Implementations
{
    public class LoginImpl : ILogin
    {
        public LoginSucessDTO login(LoginDataModel loginData)
        {
            string email = loginData.Email;
            string password = loginData.Password;

            bool isEmailValid = !String.IsNullOrEmpty(loginData.Email);
            bool isPasswordValid = false;

            if (loginData.Password.Length > 0) 
            {
                isPasswordValid = true;
            }
            LoginSucessDTO loginDto = null;
            if (isEmailValid && isPasswordValid) 
            {
                LoginDataHandler loginDBHandler = new LoginDataHandler("habbitCollection");

                try
                {
                    loginDto = loginDBHandler.Login(loginData).Result;
                }
                catch (System.AggregateException) 
                {
                    loginDto = new LoginSucessDTO();
                    loginDto.LoginStatus = false;
                }

            }



            return loginDto;
        }
    }
}
