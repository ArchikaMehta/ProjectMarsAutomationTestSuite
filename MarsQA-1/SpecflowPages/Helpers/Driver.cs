using BoDi;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQA_1.Helpers
{
    public abstract class Driver
    {
        public readonly IWebDriver _driver;

        //Created constructor for dependency injection
        public Driver(IWebDriver driver)
        {
            _driver = driver;
        }
        public static string BaseUrl
        {
            get { return ConstantHelpers.Url; }
        }

        public void NavigateUrl()
        {
            //Navigate to the application URL
            _driver.Navigate().GoToUrl(BaseUrl);
        }

        //Implementing Explicit wait

        public static void WaitClickable(IWebDriver driver, String attribute, String value, int seconds)
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, seconds));
            if (attribute == "Id")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible((By.Id(value))));
            }
            else if (attribute == "XPath")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(value)));
            }
            else if (attribute == "CssSelector")
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.CssSelector(value)));
            }
        }
    }
}
