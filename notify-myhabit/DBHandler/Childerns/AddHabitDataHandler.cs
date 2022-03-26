using HabitApp.Models;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HabitApp.DBHandler.Childerns
{
    public class AddHabitDataHandler : DBHandler
    {
        public AddHabitDataHandler(String collectionName) : base(collectionName)
        {

        }

        public Task<bool> AddHabit(HabitModel habit)
        {
            bool status = false;

            Task addHabitTask = collection.InsertOneAsync(habit.ToBsonDocument());

            addHabitTask.Wait();

            if (addHabitTask.IsCompleted)
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
