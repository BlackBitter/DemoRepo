using ClassLibrary1.Test.Pages;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Test.Actions
{
    internal class LoginPageAction : BaseActions
    {
        public LoginPageAction(IWebDriver driver) : base(driver)
        {
        }

        public void Login()
        {
            Driver.FindElement(By.XPath(LoginPage.UserNameXpath)).SendKeys("");
        }

        public string GetTitle()
        {
            return Driver.Title;
        }
    }
}
