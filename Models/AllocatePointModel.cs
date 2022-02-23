using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HabitApp.Models
{
    public class AllocatePointModel
    {
        [BsonId]
        public string habitId { get; set; }
        public int habitPoints { get; set; }
    }
}
