using HabitApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HabitApp.Pages
{
    public class LandingPageModel : PageModel
    {

        public HabitModel HabitModel { get; set; }

        public void OnGet()
        {
        }
    }
}
