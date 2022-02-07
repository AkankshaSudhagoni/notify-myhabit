using HabitApp.Models;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HabitApp.DBHandler.Childerns
{
    public class UpdateHabitDataHandler : DBHandler
    {
        public UpdateHabitDataHandler(string collectionName) : base(collectionName)
        {

        }

        public Task<bool> UpdateHabit(HabitModel habit)
        {
            bool status = false;

            //create a custom bson to pass data to update

            BsonDocument bd = new BsonDocument();
            bd.Add("habitTitle",habit.habitTitle);
            bd.Add("habitDescription",habit.habitDescription);
            bd.Add("habitImage",habit.habitImage);
            bd.Add("habitVideoUrl",habit.habitVideoUrl);
            bd.Add("habitAudio",habit.habitAudio);
            bd.Add("habitStatus",habit.habitStatus);
            bd.Add("habitPoints",habit.habitPoints);
            bd.Add("userId",habit.userId);


            //update
            Task updateHabitTask = collection.ReplaceOneAsync("{ _id: ObjectId('"+habit.habitId.ToString()+"')  }", bd);
            
            updateHabitTask.Wait();

            if (updateHabitTask.IsCompleted)
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
