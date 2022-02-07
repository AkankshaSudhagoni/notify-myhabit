using HabitApp.DBHandler.Childerns;
using HabitApp.Models;
using HabitApp.Services.Interfaces;
using System;

namespace HabitApp.Services.Implementations
{
    public class AllocatePointsImpl : IAllocatePoints
    {
        //valid date and invoke method to update points of the habit
        public bool addPoints(HabitModel habit)
        {
            bool isHabitTitleValid = !String.IsNullOrEmpty(habit.habitTitle);
            bool isHabitPointsValid = false;
            if (habit.habitPoints > 0)
            { 
                isHabitPointsValid = true;
            
            }

            bool isSucess = false;

            if (isHabitPointsValid)
            {
                AllocatePointDataHandler addPointDataHandler = new AllocatePointDataHandler("habits");

                bool status = addPointDataHandler.AdminAllocatePoints(habit).Result;

                if (status)
                {
                    isSucess = status;
                }
            }

            return isSucess;
        }

    }
}
