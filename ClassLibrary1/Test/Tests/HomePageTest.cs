using ClassLibrary1.Test.Actions;
using NUnit.Framework;
using NUnit.Framework.Constraints;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Test.Tests
{
    [TestFixture]
    public class HomePageTest : BaseTest
    {
        [Test]
        public void VerifyDropDownPageHeader()
        {
            string expectedText = "Dropdown List";
            HomePageAction homePageAction = new HomePageAction(Driver);
            homePageAction.OpenDropDownPage();

            DropDownPageAction dropDownPageAction = new DropDownPageAction(Driver);
            string actualText = dropDownPageAction.GetTextOfMainHeader();

            TestReport.Log(AventStack.ExtentReports.Status.Info, "Verifying expected text");
            Assert.AreEqual(expectedText, actualText);
            TestReport.Log(AventStack.ExtentReports.Status.Pass, "Verifyed expected text");
        }
    }
}
