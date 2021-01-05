using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace KursSelenium.Tasks
{
    class Task3_proste_lokatory
    {
        IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Position = new Point(8, 30);
            driver.Manage().Window.Size = new Size(1290, 730);
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(5);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
        }

        [Test]
        public void FindingObiects()
        {
            driver.Navigate().GoToUrl("https://fakestore.testelka.pl/moje-konto/");
            string expectURL = "https://fakestore.testelka.pl/moje-konto/";
            Assert.AreEqual(expectURL, driver.Url, "url is not correct");

            IWebElement myAccountHeader = driver.FindElement(By.ClassName("entry-title"));
            //IWebElement myAccountHeader = driver.FindElement(By.TagName("h1")); tutaj za pomocą taga

            IWebElement loginField = driver.FindElement(By.Id("username"));
            //IWebElement loginField = driver.FindElement(By.Name("username")); tutaj za pomocą name

            IWebElement passwordField = driver.FindElement(By.Id("password"));

            IWebElement rememberMeCheckbox = driver.FindElement(By.Id("rememberme"));
            //IWebElement rememberMeCheckbox = driver.FindElement(By.ClassName("woocommerce-form__input-checkbox")); tutaj za pomocą class

            IWebElement loginButton = driver.FindElement(By.Name("login"));

            IWebElement resetPasswordLink = driver.FindElement(By.LinkText("Nie pamiętasz hasła?"));
            //IWebElement resetPasswordLink2 = driver.FindElement(By.ClassName("login")).FindElement(By.TagName("a"));  wyszukanie najpierw klasy "login" a potem linku w klasie 
        }




        [TearDown]
        public void QuitDriver()
        {
            driver.Quit();
        }
    }
}
