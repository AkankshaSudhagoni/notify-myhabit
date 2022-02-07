using HabitApp.DBHandler.Childerns;
using HabitApp.Models;
using HabitApp.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HabitApp.Services.Implementations
{
    public class UpdateHabitImpl : IUpadeHabit
    {
        public bool updateHabit(HabitModel habit)
        {
            bool isHabitTitleValid = !String.IsNullOrEmpty(habit.habitTitle);
            bool isHabitDescriptionValid = !String.IsNullOrEmpty(habit.habitDescription);
            bool isHabitImageValid = !String.IsNullOrEmpty(habit.habitImage);
            bool isSucess = false;

            if (isHabitTitleValid && isHabitDescriptionValid && isHabitImageValid)
            {
                UpdateHabitDataHandler updateHabitDataHandler = new UpdateHabitDataHandler("habits");

                bool status = updateHabitDataHandler.UpdateHabit(habit).Result;

                if (status)
                {
                    isSucess = status;
                }
            }

            return true;
        }
    }
}
