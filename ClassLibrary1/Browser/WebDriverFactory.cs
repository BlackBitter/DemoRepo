using Newtonsoft.Json;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Browser
{
    public class WebDriverFactory
    {
        public IWebDriver GetDriver()
        {
            string str = File.ReadAllText("appsettings.json");
            AppSettings appSettings = JsonConvert.DeserializeObject<AppSettings>(str);

            return  appSettings.Browser switch
            {
                "Chrome" => new ChromeDriver(),
                "IE" => null,
                _ => new ChromeDriver(),
            };
        }
    }
}
