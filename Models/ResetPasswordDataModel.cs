using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HabitApp.Models
{
    public class ResetPasswordDataModel
    {
        public String code { get; set; }
        public String newPassword { get; set; }
        public String confirmPassword { get; set; }

    }
}
