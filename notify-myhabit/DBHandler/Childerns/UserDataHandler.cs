using HabitApp.Models;
using HabitApp.Utils;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HabitApp.DBHandler.Childerns
{
    public class UserDataHandler : DBHandler
    {
        public UserDataHandler(String collectionName) : base(collectionName)
        {

        }

        //find the user by email and update the password
        public bool FindUserByEmailandUpdate(String email, string newPassword)
        {
            bool status = false;
            try
            {
                Task<BsonDocument> resetPasswordTask = collection.FindAsync(new BsonDocument { { "Email", email } }).Result.FirstAsync();

                UserModel userModel = new UserModel();
                resetPasswordTask.Wait();
                userModel.FullName = resetPasswordTask.Result.GetValue("FullName").ToString();
                userModel.Email = resetPasswordTask.Result.GetValue("Email").ToString();
                userModel.Password = Hashing.Base64Encode(newPassword);
                ObjectId id = resetPasswordTask.Result.GetValue("_id").AsObjectId;
                


                BsonDocument bd = new BsonDocument();
                bd.Add("FullName", userModel.FullName);
                bd.Add("Email", userModel.Email);
                bd.Add("Password", userModel.Password);

                if (resetPasswordTask.IsCompleted)
                {
                    Task saveusertask = collection.ReplaceOneAsync("{ _id : ObjectId('" + id.ToString() + "') }", bd);

                    saveusertask.Wait();

                    if (saveusertask.IsCompleted)
                    {
                        status = true;
                    }
                    else
                    {
                        status = false;
                    }
                }

            }
            catch (Exception) 
            {

            }
            return status;
        } 
    }
}
