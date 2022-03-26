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
             IndexModel indexModel = new IndexModel((ILogger<IndexModel>)l);
            
        }
    }
}
