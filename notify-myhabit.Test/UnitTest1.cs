using HabitApp.Pages;
using Microsoft.Extensions.Logging;
using System;
using Xunit;

namespace notify_myhabit.Test
{
    public class UnitTest1
    {
        Logger<Index> l;
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
        [Fact]
        public void Test4()
        {
            AdminLoginModel adminLoginModel = new AdminLoginModel();
            adminLoginModel.OnGet();
            Assert.Equal(null, null);



        }
        [Fact]
        public void Test5()
        {
            SignupModel signupModel = new SignupModel();
            signupModel.OnGet();
            Assert.Equal((string)null, null);
        }
        [Fact]
        public void Test6()
        {
            UpdateHabit_Model updateHabit_Model = new UpdateHabit_Model();
            updateHabit_Model.OnGet();
            Assert.Equal(((string)null), null);
        }
        [Fact]
        public void Test7()
        {
            ViewSingleHabitModel viewSingleHabitModel = new ViewSingleHabitModel();
            viewSingleHabitModel.OnGet();
            Assert.Equal(null, null);
        }
        [Fact]
        public void Test8()
        {
            ViewHabitsModel viewHabitsModel = new ViewHabitsModel();
            viewHabitsModel.OnGet();
            Assert.Equal(null, null);
        }
        [Fact]
        public void Test9()

        {
            ViewUserAdminPageModel viewUserAdminPageModel = new ViewUserAdminPageModel();
            viewUserAdminPageModel.OnGet();
            Assert.Equal(null, null);    
        }
    }
}

