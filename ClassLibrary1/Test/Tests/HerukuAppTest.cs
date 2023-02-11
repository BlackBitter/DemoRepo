using ClassLibrary1.Report;
using ClassLibrary1.Test.Actions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Test.Tests
{
    [TestFixture]
    internal class HerukuAppTest : BaseTest
    {
        [Test]
        public void ABTestingTest()
        {
            Reporter.Log("Test");

            HerukoAppHomePageAction herukoAppHomePageAction = new HerukoAppHomePageAction(Driver);
            herukoAppHomePageAction.OpenABTesting();

            ABTestingPageAction aBTestingPageAction = new ABTestingPageAction(Driver);
            Assert.AreEqual("A/B Test Control2", aBTestingPageAction.GetMainHeaderText());
        }

        [Test]
        public void ABTestingTest1()
        {
            HerukoAppHomePageAction herukoAppHomePageAction = new HerukoAppHomePageAction(Driver);
            herukoAppHomePageAction.OpenABTesting();

            ABTestingPageAction aBTestingPageAction = new ABTestingPageAction(Driver);
            Assert.AreEqual("A/B Test Control", aBTestingPageAction.GetMainHeaderText());
        }
    }
}
