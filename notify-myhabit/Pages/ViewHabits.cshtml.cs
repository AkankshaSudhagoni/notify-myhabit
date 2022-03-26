using HabitApp.DBHandler.Childerns;
using HabitApp.Models;
using HabitApp.Services.Implementations;
using HabitApp.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace HabitApp.Pages
{
    public class ViewHabitsModel : PageModel
    {   [BindProperty]
        public IEnumerable<HabitModel> HabitDataModels { get; set; }

        [BindProperty]
        public UpdateHabitModel HabitModel { get; set; }

        public void OnGet()
        {



        }

   

        public void OnPost() 
        {
            if (HabitModel.habitDescription == "delete")
            {
                IViewHabit viewHabitService = new ViewHabitImpl();
                viewHabitService.deleteHabit(ObjectId.Parse(HabitModel.habitId.ToString()));

                HabitDataModels = null;


            }
            else if(HabitModel.habitDescription == null)
            {
                IViewHabit viewHabitService = new ViewHabitImpl();
                HabitDataModels = viewHabitService.getHabitModelsById(ObjectId.Parse(HabitModel.habitId));
            }
            else
            {
                IUpadeHabit updateHabitService = new UpdateHabitImpl();
                HabitModel HabitData = new HabitModel();

                HabitData.habitId = ObjectId.Parse(HabitModel.habitId);
                HabitData.habitTitle = HabitModel.habitTitle;
                HabitData.habitDescription = HabitModel.habitDescription;
                HabitData.habitAudio = HabitModel.habitAudio;
                HabitData.habitImage = HabitModel.habitImage;
                HabitData.habitVideoUrl = HabitModel.habitVideoUrl;
                HabitData.habitPoints = HabitModel.habitPoints;
                HabitData.habitStatus = HabitModel.habitStatus;
                HabitData.userId = ObjectId.Parse(HabitModel.userId);




                bool isSucess = updateHabitService.updateHabit(HabitData);

                HabitDataModels = null;
            }


        }


    }
}
