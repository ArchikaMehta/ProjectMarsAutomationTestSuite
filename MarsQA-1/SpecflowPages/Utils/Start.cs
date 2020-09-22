using BoDi;
using MarsQA_1.Helpers;
using MarsQA_1.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using TechTalk.SpecFlow;
using static MarsQA_1.Helpers.CommonMethods;

namespace MarsQA_1.Utils
{
    [Binding]
    public sealed class Start 
    {
        //Initialize the browser
        private IWebDriver _driver;
        private readonly IObjectContainer _objectContainer;

        public Start(IObjectContainer objectContainer)
        {
            _objectContainer = objectContainer;
        }

        [BeforeScenario]
        public void Setup()
        {
            //launch the browser
            Initialize();
            ExcelLibHelper.PopulateInCollection(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\SpecflowTests\Data\Mars.xlsx", "Credentials");
            //call the SignIn class
            //SignIn.SigninStep();
            ExtentReports();
        }

        private IWebDriver Initialize()
        {
            //Defining the browser   
            _driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            _objectContainer.RegisterInstanceAs(_driver);
            //Maximise the window
            _driver.Manage().Window.Maximize();

            return _driver;
        }

        [AfterScenario]
        public void TearDown()
        {
            // Screenshot
            string img = SaveScreenShotClass.SaveScreenshot(_driver, "Report");            
            test.Log(LogStatus.Info, "Snapshot below: " + test.AddScreenCapture(img));

            //Close the browser
            _driver.Close();
            _driver.Dispose();
             
            // end test. (Reports)
            CommonMethods.Extent.EndTest(test);
            
            // calling Flush writes everything to the log file (Reports)
            CommonMethods.Extent.Flush();
        }
    }
}
