using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using MongoDB.Bson;
using System.Threading.Tasks;
using HabitApp.Models;
using HabitApp.Services.Implementations;
using HabitApp.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HabitApp.Pages
{
    public class AddHabitModel : PageModel
    {
        [BindProperty]
        public AddHabitDataModel AddHabitData { get; set; }
        public void OnGet()
        {

        }

       
        public IActionResult OnPost()
        {
            IAddHabit addHabitService = new AddHabitImpl();
            HabitModel HabitData = new HabitModel();

            HabitData.habitTitle = AddHabitData.habitTitle;
            HabitData.habitDescription = AddHabitData.habitDescription;
            HabitData.habitAudio = AddHabitData.habitAudio;
            HabitData.habitImage = AddHabitData.habitImage;  
            HabitData.habitVideoUrl = AddHabitData.habitVideoUrl;
            HabitData.userId = ObjectId.Parse(AddHabitData.userId);




            bool isSucess = addHabitService.addHabit(HabitData);
             

            if (isSucess)
            {
                return RedirectToPage("/viewhabits");
            }


            return null;  
        }


    }
}
