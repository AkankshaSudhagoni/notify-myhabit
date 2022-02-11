using HabitApp.DBHandler.Childerns;
using HabitApp.Models;
using HabitApp.Services.Interfaces;
using System;

namespace HabitApp.Services.Implementations
{
    public class AdminLoginImpl : ILogin
    {
        public LoginSucessDTO login(LoginDataModel loginData)
        {
            //validate credentials and call login method 
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
                AdminLoginDataHandler loginDBHandler = new AdminLoginDataHandler("adminData");

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
