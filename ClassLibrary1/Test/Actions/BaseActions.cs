using AventStack.ExtentReports;
using ClassLibrary1.Report;
using ClassLibrary1.Test.Tests;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Test.Actions
{
    public class BaseActions
    {
        public BaseActions(IWebDriver driver)
        {
            Driver = driver;
        }

        protected IWebDriver Driver { get; set; }

        protected void Log(string message)
        {
            Reporter.Log(message);
        }
    }
}
