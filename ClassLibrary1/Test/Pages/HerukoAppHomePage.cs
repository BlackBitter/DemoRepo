using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Test.Pages
{
    public class HerukoAppHomePage 
    {
        public static By ABTestingLink => LinkXpath("A/B Testing");

        public static By AddRemoveElements => LinkXpath("Add/Remove Elements");

        private static By LinkXpath(string label) => By.XPath($"//a[normalize-space()='{label}']");
    }
}
