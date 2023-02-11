using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using ClassLibrary1.Test.Tests;

namespace ClassLibrary1.Report
{
    internal class Reporter
    {
        public static ExtentReports SuiteReport { get; set; }

        static Reporter()
        {
            SuiteReport = new ExtentReports();
            SuiteReport.AttachReporter(new ExtentHtmlReporter(@"C:\Test\Demo\test.html"));
        }

        public static ExtentTest TestReport
        {
            get
            {
                return BaseTest.TestReport;
            }
        }

        public static void Log(string message)
        {
            TestReport.Log(Status.Info, message);
        }
    }
}
