using HabitApp.Models;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HabitApp.DBHandler.Childerns
{
    public class ResetPasswordDataHandler : DBHandler
    {
        public ResetPasswordDataHandler(string collectionName) : base(collectionName)
        {

        }

        //this method retrive the email of the user for relevent code
        public String ResetPassword(ResetPasswordDataModel resetPassword)
        {
            try
            {
                String code = resetPassword.code;
            String email = "";
            Task<BsonDocument> resetPasswordTask = collection.FindAsync(new BsonDocument { { "Code", code } }).Result.FirstAsync();

            
                email = resetPasswordTask.Result.GetValue("Email").ToString();
            
            resetPasswordTask.Wait();

            if (resetPasswordTask.IsCompleted)
            {

                return email;

            }

            }
            catch (Exception)
            {
            }
            return "";


        }
      
    }
}
