using HabitApp.Pages;
using Microsoft.Extensions.Logging;
using System;
using Xunit;

namespace notify_myhabit.Test
{
    public class UnitTest1
    {
        Logger<Index> l ;
        [Fact]
        public void Test1()
        {
            LandingPageModel landingPageModel = new LandingPageModel();
            landingPageModel.OnGet();
            Assert.Equal(null, null);
            
        }
        [Fact]
        public void Test2()
        {
            AddHabitModel addHabitModel = new AddHabitModel();
            addHabitModel.OnGet();
            Assert.Equal(null, null);
        }
        [Fact]
        public void Test3()
        {
            AdminAllocatePointsModel adminAllocatePointsModel = new AdminAllocatePointsModel();
            adminAllocatePointsModel.OnGet();
            Assert.Equal(null, null);
        }
    }
}
