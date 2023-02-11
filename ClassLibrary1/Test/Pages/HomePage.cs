using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Test.Pages
{
    public class HomePage
    {
        public static By DropDownLink => Link("Dropdown");

        public static By DragAndDropLink => Link("Drag and Drop");

        public static By Link(string label)
        {
            return  By.XPath($"//a[normalize-space()='{label}']");
        }
    }
}
