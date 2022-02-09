using HabitApp.Models;

namespace HabitApp.Services.Interfaces
{
    public interface IAllocatePoints
    {
        public bool addPoints(HabitModel habit);
    }
}
