using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace KursSelenium.Tasks
{
    class Task1
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
        public void FirstTest()
        {
            string wikipediaUrl = "https://pl.wikipedia.org/wiki/Wikipedia:Strona_g%C5%82%C3%B3wna";
            string nasaUrl = "https://www.nasa.gov/";
            driver.Navigate().GoToUrl(wikipediaUrl);
            Assert.AreEqual(wikipediaUrl, driver.Url, "Something is wrong - You are not on Wikipedia");
            driver.Navigate().GoToUrl(nasaUrl);
            Assert.AreEqual(nasaUrl, driver.Url, "Something is wrong - You are not on Nasa");
            driver.Navigate().Back();
            Assert.AreEqual(wikipediaUrl, driver.Url, "Something is wrong - You are not on Wikipedia");
        }

        [Test]
        public void Second()
        {
            string wikipediaUrl = "https://pl.wikipedia.org/wiki/Wikipedia:Strona_g%C5%82%C3%B3wna";
            string nasaUrl = "https://www.nasa.gov/";
            driver.Navigate().GoToUrl(wikipediaUrl);
            Assert.AreEqual(wikipediaUrl, driver.Url, "Something is wrong - You are not on Wikipedia");
            driver.Navigate().GoToUrl(nasaUrl);
            Assert.AreEqual(nasaUrl, driver.Url, "Something is wrong - You are not on Nasa");
            driver.Navigate().Back();
            Assert.AreEqual(wikipediaUrl, driver.Url, "Something is wrong - You are not on Wikipedia");
            driver.Navigate().Forward();
            Assert.AreEqual(nasaUrl, driver.Url, "Something is wrong - You are not on Nasa");
        }
        
        [TearDown]
        public void CloseChromeAndSesion()
        {
            driver.Close();
            driver.Quit();
        }
    }
}
