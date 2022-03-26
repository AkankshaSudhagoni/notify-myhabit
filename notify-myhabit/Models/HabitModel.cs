using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HabitApp.Models
{
    public class HabitModel
    {
        [BsonId]
        public ObjectId habitId { get; set; }
        public string habitTitle { get; set; }
        public string habitDescription { get; set; }
        public string habitImage { get; set; }
        public string habitVideoUrl { get; set; }
        public string habitAudio { get; set; }
        public bool habitStatus { get; set; }
        public int habitPoints { get; set; }
        public ObjectId userId { get; set; }

        public HabitModel()
        {
        }

        public HabitModel(ObjectId habitId, string habitTitle, string habitDescription, string habitImage, string habitVideoUrl, string habitAudio, bool habitStatus, int habitPoints, ObjectId userId)
        {
            this.habitId = habitId;
            this.habitTitle = habitTitle;
            this.habitDescription = habitDescription;
            this.habitImage = habitImage;
            this.habitVideoUrl = habitVideoUrl;
            this.habitAudio = habitAudio;
            this.habitStatus = habitStatus;
            this.habitPoints = habitPoints;
            this.userId = userId;
        }

        public HabitModel(string habitTitle, string habitDescription, string habitImage)
        {
            
            this.habitTitle = habitTitle;
            this.habitDescription = habitDescription;
            this.habitImage = habitImage;
            
        }



    }
}
