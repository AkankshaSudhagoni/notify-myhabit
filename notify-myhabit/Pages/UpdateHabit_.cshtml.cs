using HabitApp.Models;
using HabitApp.Services.Implementations;
using HabitApp.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MongoDB.Bson;

namespace HabitApp.Pages
{
    public class UpdateHabit_Model : PageModel
    {
        [BindProperty]
        public UpdateHabitModel UpdateHabitData { get; set; }
        public void OnGet()
        {

        }


        public IActionResult OnPost()
        {
            IUpadeHabit updateHabitService = new UpdateHabitImpl();
            HabitModel HabitData = new HabitModel();

            HabitData.habitId = ObjectId.Parse(UpdateHabitData.habitId);
            HabitData.habitTitle = UpdateHabitData.habitTitle;
            HabitData.habitDescription = UpdateHabitData.habitDescription;
            HabitData.habitAudio = UpdateHabitData.habitAudio;
            HabitData.habitImage = UpdateHabitData.habitImage;
            HabitData.habitVideoUrl = UpdateHabitData.habitVideoUrl;
            HabitData.habitPoints = UpdateHabitData.habitPoints;
            HabitData.habitStatus = UpdateHabitData.habitStatus;
            HabitData.userId = ObjectId.Parse(UpdateHabitData.userId);




            bool isSucess = updateHabitService.updateHabit(HabitData);


            if (isSucess)
            {
                return RedirectToPage("/viewhabits");
            }


            return null;
        }


    
    }
}
