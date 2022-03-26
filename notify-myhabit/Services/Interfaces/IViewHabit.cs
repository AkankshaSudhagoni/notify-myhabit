using HabitApp.Models;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HabitApp.Services.Interfaces
{
    interface IViewHabit
    {
        public List<HabitModel> getHabitModels();
        public List<HabitModel> getHabitModelsById(ObjectId userId);
        public bool deleteHabit(ObjectId userId);
    }
}
