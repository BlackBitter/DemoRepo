using AventStack.ExtentReports;
using ClassLibrary1.Browser;
using ClassLibrary1.Report;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using NUnit.Framework;
using NUnit.Framework.Constraints;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Test.Tests
{
    // base test
    [TestFixture]
    public class BaseTest
    {
        protected IWebDriver Driver { get; set; }

        public static ExtentTest TestReport { get; set; }

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {

        }

        [SetUp]
        public void Setup()
        {
            TestReport = Reporter.SuiteReport.CreateTest(TestContext.CurrentContext.Test.FullName);

            string str = File.ReadAllText("appsettings.json");
            AppSettings appSettings = JsonConvert.DeserializeObject<AppSettings>(str);
            
            WebDriverFactory webDriver = new WebDriverFactory();

            Driver = webDriver.GetDriver();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Driver.Manage().Window.Maximize();

            Driver.Navigate().GoToUrl(appSettings.HomePage);
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();

            if(TestContext.CurrentContext.Result.Outcome.Status == NUnit.Framework.Interfaces.TestStatus.Passed)
            {
                TestReport.Log(Status.Pass);
            }
            else
            {
                TestReport.Log(Status.Fail);
            }
        }
    }
}
