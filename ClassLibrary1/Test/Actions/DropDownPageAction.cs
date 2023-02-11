using ClassLibrary1.Test.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Test.Actions
{
    public class DropDownPageAction : BaseActions
    {
        public DropDownPageAction(IWebDriver driver) : base(driver)
        {
        }

        public string GetTextOfMainHeader()
        {
            Log("Getting MainHeader text");
            WebDriverWait webDriverWait = new WebDriverWait(Driver, TimeSpan.FromSeconds(60));
            webDriverWait.Until((d) => d.FindElement(DropDownPage.MainHeader));
            string text = Driver.FindElement(DropDownPage.MainHeader).Text;
            Log($"Got {text} from MainHeader");
            return text;
        }
    }
}
