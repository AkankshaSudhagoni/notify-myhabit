using HabitApp.Models;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Threading.Tasks;

namespace HabitApp.DBHandler.Childerns
{
    public class AdminLoginDataHandler : DBHandler
    {
        public AdminLoginDataHandler(string collectionName) : base(collectionName)
        {

        }

        public Task<LoginSucessDTO> Login(LoginDataModel loginData)
        {
            bool status = false;

            //save Admin data to database and return UserModel

            Task<BsonDocument> loginTask = collection.FindAsync(new BsonDocument { { "Email", loginData.Email }, { "Password", loginData.Password } }).Result.FirstAsync();

            loginTask.Wait();

            String Email = loginTask.Result.GetValue("Email").ToString();
            ObjectId UserId = loginTask.Result.GetValue("_id").AsObjectId;

            

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
            lsdto.UserId = UserId;

            return Task.FromResult(lsdto);

        }
    }
}
