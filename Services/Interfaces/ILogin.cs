using HabitApp.Models;


namespace HabitApp.Services.Interfaces
{
    interface ILogin
    {
        public LoginSucessDTO login(LoginDataModel loginData);
    }
}
