using ClassLibrary1.Test.Pages;
using ClassLibrary1.Test.Tests;
using OpenQA.Selenium;

namespace ClassLibrary1.Test.Actions
{
    internal class ABTestingPageAction : BaseActions
    {
        public ABTestingPageAction(IWebDriver driver) : base(driver)
        {
        }

        public string GetMainHeaderText()
        {
            //TestReport.Log(AventStack.ExtentReports.Status.Info, "Fetching MainHeader Text");
            string text = Driver.FindElement(ABTestingPage.MainHeader).Text;
            //TestReport.Log(AventStack.ExtentReports.Status.Info, $"Fetched {text} Text");
            return text;
        }
    }
}
