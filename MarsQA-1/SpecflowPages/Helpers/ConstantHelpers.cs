using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MarsQA_1.Helpers
{
    public class ConstantHelpers
    {
        //Base Url
        public static string Url = "http://192.168.99.100:5000";

        //ScreenshotPath
        //public static string ScreenshotPath =  @"C:\Study\IndustryConnect\git\ProjectMarsAutomationTestSuite1\MarsQA-1\TestReports\Screenshots\";
        public static string ScreenshotPath = (Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"../../../\TestReports\Screenshots\");

        //ExtentReportsPath
       // public static string ReportsPath = @"C:\Study\IndustryConnect\git\ProjectMarsAutomationTestSuite1\MarsQA-1\TestReports\Report\MarsQA_AutomationTestReport.html";
        public static string ReportsPath = (Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"../../../\TestReports\Report\MarsQA_AutomationTestReport.html");

        //ReportXML Path
        //public static string ReportXMLPath = @"C:\Study\IndustryConnect\git\ProjectMarsAutomationTestSuite1\MarsQA-1\TestReports\Report\MarsQA_AutomationTestReport_Config.xml";
        public static string ReportXMLPath = (Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)+ @"../../../\TestReports\Report\MarsQA_AutomationTestReport_Config.xml");
    }
}