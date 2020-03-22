using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace KursSelenium.DriverMethods
{
    class Navigation
    {
        IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Position = new System.Drawing.Point(8, 30);
            driver.Manage().Window.Size = new System.Drawing.Size(1290, 730);

            driver.Manage().Timeouts().ImplicitWait = System.TimeSpan.FromSeconds(5);
            driver.Manage().Timeouts().PageLoad = System.TimeSpan.FromSeconds(5);
        }

        [Test]
        public void GoToUrlTest()
        {
            driver.Navigate().GoToUrl("https://google.pl");
            string expectedURL = "https://www.google.pl/";
            Assert.AreEqual(expectedURL, driver.Url, "Url is not correct");
        }

        [Test]
        public void BackTest()
        {
            string googleURL = "https://www.google.pl/";
            string amazonURL = "https://amazon.com";
            driver.Navigate().GoToUrl(googleURL);
            driver.Navigate().GoToUrl(amazonURL);
            driver.Navigate().Back();
            string expectedURL = "https://www.google.pl/";
            Assert.AreEqual(expectedURL, driver.Url, "Url is not correct");
        }

        [Test]
        public void ForwardTest()
        {
            string googleURL = "https://www.google.pl/";
            string amazonURL = "https://amazon.com";
            driver.Navigate().GoToUrl(amazonURL);
            driver.Navigate().GoToUrl(googleURL);
            driver.Navigate().Back();
            driver.Navigate().Forward();
            string expectedURL = "https://www.google.pl/";
            Assert.AreEqual(expectedURL, driver.Url, "Url is not correct");
        }

        [Test]
        public void Refreshtest()
        {
            string allegroUrl = "https://allegro.pl";
            driver.Navigate().GoToUrl(allegroUrl);
            driver.Navigate().Refresh();
            Thread.Sleep(5000);
        }

        [TearDown]
        public void QuitDriver()
        {
            driver.Quit();
        }
    }
}
