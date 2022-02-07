using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HabitApp.Models
{
    public class UpdateHabitModel
    {

        [BsonId]
        public string habitId { get; set; }
        public string habitTitle { get; set; }
        public string habitDescription { get; set; }
        public string habitImage { get; set; }
        public string habitVideoUrl { get; set; }
        public string habitAudio { get; set; }
        public bool habitStatus { get; set; }
        public int habitPoints { get; set; }
        public string userId { get; set; }
    }
}
