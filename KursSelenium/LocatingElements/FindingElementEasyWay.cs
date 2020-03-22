using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Drawing;
using NUnit.Framework;

namespace KursSelenium.LocatingElements
{
    class FindingElementEasyWay
    {
        IWebDriver driver;

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Position = new Point(8, 30);
            driver.Manage().Window.Size = new Size(1290, 730);
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(5);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
        }

        [Test]
        public void LocatingElementsTest()
        {
            driver.Navigate().GoToUrl("https://fakestore.testelka.pl/");
            IWebElement search = driver.FindElement(By.Id("woocommerce-product-search-field-0"));
            search.SendKeys("el gouna");
            search.Submit();
            Assert.AreEqual("Egipt – El Gouna – FakeStore",driver.Title, "Page title is not corrrect");
        }

        [Test]
        public void LocatingElementsTest1()
        {
            driver.Navigate().GoToUrl("https://fakestore.testelka.pl/");
            //driver.FindElement(By.TagName("header")).FindElement(By.ClassName("search-field")); rozpiszemy to ponizej na mniejsze czesci, szukanie elementu w elementach
            IWebElement header = driver.FindElement(By.TagName("header"));
            IWebElement search = header.FindElement(By.ClassName("search-field"));
            search.SendKeys("el gouna");
            search.Submit();
            Assert.AreEqual("Egipt – El Gouna – FakeStore", driver.Title, "Page title is not corrrect");
        }

        [Test]
        public void LocatingElementsTest2()
        {
            driver.Navigate().GoToUrl("https://fakestore.testelka.pl/");
            // po name
            IWebElement header = driver.FindElement(By.TagName("header"));
            IWebElement search = header.FindElement(By.Name("s"));
            search.SendKeys("el gouna");
            search.Submit();
            Assert.AreEqual("Egipt – El Gouna – FakeStore", driver.Title, "Page title is not corrrect");
        }

        [TearDown]
        public void CloseChromeAndSesion()
        {
            driver.Quit();
        }
    }
}
