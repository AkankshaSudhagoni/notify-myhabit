using HabitApp.Models;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HabitApp.DBHandler.Childerns
{
    public class ForgotPasswordDataHandler : DBHandler
    {
        public ForgotPasswordDataHandler(string collectionName) : base(collectionName)
        {

        }

        public Task<bool> ForgotPassward(ForgotDataModel forgotDataModel)
        {
            bool status = false;

            
            Task forgotPasswordTask = collection.InsertOneAsync(forgotDataModel.ToBsonDocument());

            forgotPasswordTask.Wait();

            if (forgotPasswordTask.IsCompleted)
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
