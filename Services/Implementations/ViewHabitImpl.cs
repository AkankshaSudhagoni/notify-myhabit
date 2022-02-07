using HabitApp.DBHandler.Childerns;
using HabitApp.Models;
using HabitApp.Services.Interfaces;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HabitApp.Services.Implementations
{
    public class ViewHabitImpl : IViewHabit
    {
        public bool deleteHabit(ObjectId habitId)
        {
            ViewHabitDataHandler viewDataHandler = new ViewHabitDataHandler("habits");

            return viewDataHandler.deleteHabit(habitId);
        }

        public List<HabitModel> getHabitModels()
        {
            List<HabitModel> modelsList = new List<HabitModel>();
            ViewHabitDataHandler viewDataHandler = new ViewHabitDataHandler("habits");

            try {

                modelsList = viewDataHandler.getHabits().Result;

            }
            catch (Exception) 
            {

            }


            return modelsList;
        }


        public List<HabitModel> getHabitModelsById(ObjectId userId)
        {
            List<HabitModel> modelsList = new List<HabitModel>();
            ViewHabitDataHandler viewDataHandler = new ViewHabitDataHandler("habits");

            try
            {

                modelsList = viewDataHandler.getHabitsByUser(userId).Result;

            }
            catch (Exception)
            {

            }


            return modelsList;
        }
    }
}
