using ClassLibrary1.Test.Pages;
using OpenQA.Selenium;

namespace ClassLibrary1.Test.Actions
{
    public class HerukoAppHomePageAction : BaseActions
    {
        public HerukoAppHomePageAction(IWebDriver driver) : base(driver)
        {
        }

        public void OpenABTesting()
        {
            Log("Opening AB Test");
            Driver.FindElement(HerukoAppHomePage.ABTestingLink).Click();
            Log("Opened AB Test");
        }
    }
}
