using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ParallelTest
{
    public class Tests
    {
        ThreadLocal<IWebDriver> driver = new ThreadLocal<IWebDriver>();

        [SetUp]
        public void Setup()
        {
            driver.Value = new ChromeDriver();
        }

        [Test]
        [Parallelizable]
        public void Test1()
        {
            Assert.Pass();
            driver.Value.Quit();
        }

        [Test]
        [Parallelizable]
        public void Test2()
        {
            Assert.Pass();
            driver.Value.Quit();
        }
    }
}