using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HabitApp.Models
{
    public class AddHabitDataModel
    {
        public string habitTitle { get; set; }
        public string habitDescription { get; set; }
        public string habitImage { get; set; }
        public string habitVideoUrl { get; set; }
        public string habitAudio { get; set; }
        public string userId { get; set; }
    }
}
