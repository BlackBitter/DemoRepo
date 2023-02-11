using ClassLibrary1.Test.Pages;
using OpenQA.Selenium;

namespace ClassLibrary1.Test.Actions
{
    public class HomePageAction : BaseActions
    {
        public HomePageAction(IWebDriver driver) : base(driver)
        {
        }

        public void OpenDropDownPage()
        {
            Log("Clicking on DropDown link");
            Driver.FindElement(HomePage.DropDownLink).Click();
            Log("Clicked on DropDown link");
        }
    }
}
