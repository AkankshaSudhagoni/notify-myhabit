using HabitApp.Models;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HabitApp.DBHandler.Childerns
{
    public class ViewHabitDataHandler : DBHandler  
    {
        public ViewHabitDataHandler(string collectionName) : base(collectionName)
        {

        }

        public Task<List<HabitModel>> getHabits()
        {
            
           //get habits list
            Task<List<BsonDocument>> ViewHabitTask = collection.Find(p => true).ToListAsync();

  
            ViewHabitTask.Wait();
            List<HabitModel> list = new List<HabitModel>();
            foreach (BsonDocument bs in ViewHabitTask.Result) 
            {
                HabitModel model = new HabitModel();
                model.habitId = bs.GetValue("_id").AsObjectId;
                model.habitTitle = bs.GetValue("habitTitle").ToString();
                model.habitDescription = bs.GetValue("habitDescription").ToString();
                model.habitImage = bs.GetValue("habitImage").ToString();
                model.habitAudio = bs.GetValue("habitAudio").ToString();
                model.habitPoints = int.Parse(bs.GetValue("habitPoints").ToString());
                model.habitStatus = bs.GetValue("habitStatus").ToBoolean();
                model.habitVideoUrl = bs.GetValue("habitVideoUrl").ToString();
                model.userId   = bs.GetValue("userId").AsObjectId;

                list.Add(model);
            }
            if (ViewHabitTask.IsCompleted)
            {
            }
            else
            {
            }

            return Task.FromResult(list);
        }

        public Task<List<HabitModel>> getHabitsByUser(ObjectId userId)
        {

            Task<List<BsonDocument>> ViewHabitTask = collection.FindAsync("{ userId: ObjectId('" + userId.ToString() + "')  }").Result.ToListAsync();

            

            ViewHabitTask.Wait();
            List<HabitModel> list = new List<HabitModel>();
            foreach (BsonDocument bs in ViewHabitTask.Result)
            {
                HabitModel model = new HabitModel();
                model.habitId = bs.GetValue("_id").AsObjectId;
                model.habitTitle = bs.GetValue("habitTitle").ToString();
                model.habitDescription = bs.GetValue("habitDescription").ToString();
                model.habitImage = bs.GetValue("habitImage").ToString();
                model.habitAudio = bs.GetValue("habitAudio").ToString();
                model.habitPoints = int.Parse(bs.GetValue("habitPoints").ToString());
                model.habitStatus = bs.GetValue("habitStatus").ToBoolean();
                model.habitVideoUrl = bs.GetValue("habitVideoUrl").ToString();
                model.userId = bs.GetValue("userId").AsObjectId;

                list.Add(model);
            }
            if (ViewHabitTask.IsCompleted)
            {
            }
            else
            {
            }

            return Task.FromResult(list);
        }

        public bool deleteHabit(ObjectId  id) 
        {
            string val = "{ _id: ObjectId('" + id.ToString() + "')}";
            Task task = collection.DeleteOneAsync("{_id:ObjectId('"+id.ToString()+"')}");
            bool status = false;
            task.Wait();

            if (task.IsCompleted) 
            {
                status = true;
            }

            return status;
        }
    }
}
