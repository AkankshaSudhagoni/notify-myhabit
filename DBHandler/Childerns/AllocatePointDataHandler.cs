using HabitApp.Models;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HabitApp.DBHandler.Childerns
{
    public class AllocatePointDataHandler : DBHandler
    {
        public AllocatePointDataHandler(String collectionName) : base(collectionName)
        {

        }
    
        public Task<bool> AdminAllocatePoints(HabitModel habit)
        {
            bool status = false;

            //create a custom bsomn to pass data to update

            BsonDocument bd = new BsonDocument();
            
             

               Task <BsonDocument> habitDetails = collection.FindAsync("{ _id: ObjectId('" + habit.habitId.ToString() + "')  }").Result.FirstAsync();

            habitDetails.Wait();

            if (habitDetails.IsCompleted)
            {
               
                bd.Add("habitTitle", habitDetails.Result.GetValue("habitTitle").ToString());
                bd.Add("habitDescription", habitDetails.Result.GetValue("habitDescription").ToString());
                bd.Add("habitImage", habitDetails.Result.GetValue("habitImage").ToString());
                bd.Add("habitVideoUrl", habitDetails.Result.GetValue("habitVideoUrl").ToString());
                bd.Add("habitAudio", habitDetails.Result.GetValue("habitAudio").ToString());
                bd.Add("habitStatus", habitDetails.Result.GetValue("habitStatus").ToString());
                bd.Add("habitPoints", habit.habitPoints);
                bd.Add("userId", habitDetails.Result.GetValue("userId"));


                Task addPointTask = collection.ReplaceOneAsync("{ _id: ObjectId('" + habit.habitId.ToString() + "')  }",bd);

                addPointTask.Wait();
                if (addPointTask.IsCompleted)
                {
                    status = true;
                }
                else
                {
                    status = false;
                }

            }
            

            return Task.FromResult(status);
        }
    }
}
