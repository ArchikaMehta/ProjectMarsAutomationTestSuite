using MarsQA_1.Helpers;
using MarsQA_1.Pages;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace MarsQA_1.Feature
{
    [Binding]
    class LoginSD 
    {
        private SignIn LoginObj;

        //Created constructor for dependency injection
        public LoginSD(IWebDriver driver)
        {
            LoginObj = new SignIn(driver);
        }
        [Given(@"I navigate to the application portal")]
        public void GivenINavigateToTheApplicationPortal()
        {
            LoginObj.NavigateUrl();
        }

        [When(@"I login using valid credentials")]
        public void WhenILoginUsingValidCredentials()
        {
            LoginObj.SigninStep();
        }


    }
}
