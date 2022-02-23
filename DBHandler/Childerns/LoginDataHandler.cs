using HabitApp.Models;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace HabitApp.DBHandler.Childerns
{
    public class LoginDataHandler : DBHandler
    {
        public LoginDataHandler(string collectionName) : base(collectionName)
        {

        }

        public Task<LoginSucessDTO> Login(LoginDataModel loginData)
        {
            bool status = false;

            //save user data to data base and return UserModel. this will pass when the eamil and password is valid combination

            Task<BsonDocument> loginTask = collection.FindAsync(new BsonDocument { { "Email", loginData.Email }, { "Password", loginData.Password } }).Result.FirstAsync();

            String FullName = loginTask.Result.GetValue("FullName").ToString();
            String Email = loginTask.Result.GetValue("Email").ToString();
            ObjectId UserId = loginTask.Result.GetValue("_id").AsObjectId; 

            loginTask.Wait();

            if (loginTask.IsCompleted)
            {

                status = true;

            }
            else
            {
                status = false;
            }

            LoginSucessDTO lsdto = new LoginSucessDTO();

            lsdto.LoginStatus = status;
            lsdto.Email = Email;
            lsdto.FullName = FullName;
            lsdto.UserId = UserId;

            return Task.FromResult(lsdto);

        }
    }
}
