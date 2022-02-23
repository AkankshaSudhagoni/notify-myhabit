using HabitApp.Models;
using HabitApp.Services.Implementations;
using HabitApp.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MongoDB.Bson;
using System.Collections.Generic;

namespace HabitApp.Pages
{
    public class AdminAllocatePointsModel : PageModel
    {
        [BindProperty]
        public IEnumerable<HabitModel> HabitDataModels { get; set; }

        [BindProperty]
        public string UserId { get; set; }

        [BindProperty]
        public AllocatePointModel AllocatePointDataModel { get; set; }

     
        public void OnGet()
        {
            IViewHabit viewHabitService = new ViewHabitImpl();
            HabitDataModels = viewHabitService.getHabitModels();
            
        }


        public IActionResult OnPost()
        {

            IAllocatePoints addPointService = new AllocatePointsImpl();
            HabitModel HabitData = new HabitModel();

            //set input values to HabitDataModel
            HabitData.habitPoints = AllocatePointDataModel.habitPoints;
            HabitData.habitId = ObjectId.Parse(AllocatePointDataModel.habitId);


            bool isSucess = addPointService.addPoints(HabitData);

            if (isSucess)
            {
                ViewData["SucessStatus"] = string.Format("200");
                ViewData["SucessfulMessage"] = string.Format("Points Updated Sucessfully!");
                AllocatePointModel AllocatePointDataModel = new AllocatePointModel();
                OnGet();

            }
            else
            {
                ViewData["SucessStatus"] = string.Format("500");
                ViewData["ErrorMessage"] = string.Format("Cannot Update Points!");
            }
            return null;
        }
    }
}
