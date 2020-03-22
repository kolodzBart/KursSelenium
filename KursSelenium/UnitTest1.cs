using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace KursSelenium
{
    public class Tests
    {
        IWebDriver driver;

       [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver(@"C:\Users\Bart³omiej\source\repos\Testelka\KursSelenium\KursSelenium\bin\Debug\netcoreapp3.0\Resources\");
        }

        [Test]
        public void Test1()
        {
            driver.Navigate().GoToUrl("https://google.pl");
        }

        [TearDown]
        public void QuitDriver()
        {
            driver.Quit();
        }
    }
}