using HabitApp.Models;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HabitApp.DBHandler.Childerns
{
    public class SignUpDataHandler : DBHandler
    {
        public SignUpDataHandler(string collectionName) : base(collectionName)
        {
            
        }


        public Task<bool> SignUp(UserModel userData) 
        {
            bool status = false;
            //save user data to data base and return UserModel

            Task signUpTask = collection.InsertOneAsync(userData.ToBsonDocument());

            signUpTask.Wait();

            if (signUpTask.IsCompleted)
            {

                status = true;

            }
            else 
            {
                status = false;
            }

            return Task.FromResult(status);



        }

    }
}
