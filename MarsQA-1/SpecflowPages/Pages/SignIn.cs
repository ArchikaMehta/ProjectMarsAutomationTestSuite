using NUnit.Framework;
using MarsQA_1.Helpers;
using MarsQA_1.Utils;
using OpenQA.Selenium;
using System.Threading;

namespace MarsQA_1.Pages
{
    internal class SignIn :Driver
    { 
        public SignIn(IWebDriver driver) : base(driver)
        {
            
        }
        //Web element for Url
        private IWebElement SignInBtn => _driver.FindElement(By.XPath("//A[@class='item'][text()='Sign In']"));
        //Web element for Username
        private IWebElement Email => _driver.FindElement(By.XPath("(//INPUT[@type='text'])[2]"));
        //Web element for password
        private IWebElement Password => _driver.FindElement(By.XPath("//INPUT[@type='password']"));
        //Web element for Login Button
        private IWebElement LoginBtn => _driver.FindElement(By.XPath("//BUTTON[@class='fluid ui teal button'][text()='Login']"));
        
        internal void SigninStep()
        {
            //Enter Url
            SignInBtn.Click();
            //Enter Username
            Email.SendKeys(ExcelLibHelper.ReadData(2,"username"));
            //Enter password
            Password.SendKeys(ExcelLibHelper.ReadData(2, "password"));
            //Click on Login Button
            LoginBtn.Click();
        }

        internal void Login()
        {
            //Enter Url
            _driver.FindElement(By.XPath("//A[@class='item'][text()='Sign In']")).Click();

            //Enter Username
            _driver.FindElement(By.XPath("(//INPUT[@type='text'])[2]")).SendKeys("");

            //Enter password
            _driver.FindElement(By.XPath("//INPUT[@type='password']")).SendKeys("");

            //Click on Login Button
            _driver.FindElement(By.XPath("//BUTTON[@class='fluid ui teal button'][text()='Login']")).Click();
        }
    }
}