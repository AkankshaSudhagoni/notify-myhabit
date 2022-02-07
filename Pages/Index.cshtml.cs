using HabitApp.DBHandler.Childerns;
using HabitApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HabitApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public HabitModel HabitModel { get; set; }
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            //generate random number and retrive the corsponding habbit
            Random myObject = new Random();
            int rand = myObject.Next(0, 5);
            RandomHabit randomHabit = new RandomHabit();

            List<HabitModel> habitlist = randomHabit.gethabitlist();

            HabitModel  habitModel = habitlist[rand];

            HabitModel = habitModel;




        }
    }
}
