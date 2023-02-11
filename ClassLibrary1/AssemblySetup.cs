using ClassLibrary1.Report;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    [SetUpFixture]
    internal class AssemblySetup
    {
        [OneTimeSetUp]
        public void Setup()
        {
            Process[] chromeDriverProcesses = Process.GetProcessesByName("chromedriver");
            foreach (var chromeDriverProcess in chromeDriverProcesses)
            {
                chromeDriverProcess.Kill();
            }
        }

        [OneTimeTearDown]
        public void TearDown()
        {
            Reporter.SuiteReport.Flush();
        }
    }
}
