using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HabitApp.Models
{
    public class LoginSucessDTO
    {
        public ObjectId UserId { get; set; }
        public string FullName { get; set; }
        public bool LoginStatus { get; set; }
        public string Email { get; set;  }
        public string Role { get; set;  }
    }
}
