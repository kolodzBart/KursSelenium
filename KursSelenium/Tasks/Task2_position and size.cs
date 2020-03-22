using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace KursSelenium.Tasks
{
    class Task2_position_and_size
    {
        IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            //driver.Manage().Window.Position = new Point(8, 30);
            //driver.Manage().Window.Size = new Size(1290, 730);
        }

        [Test]
        public void WindowPositionTest()
        {
            Point startingPoint = driver.Manage().Window.Position;
            Point expectedPoint = new Point(10, 10);
            Assert.AreEqual(expectedPoint, startingPoint, "Starting point is not (10, 10)");
        }

        [Test]
        public void WindowSizeTest()
        {
            Size startingSize = driver.Manage().Window.Size;
            Size expectedSize = new Size(945, 1020);
            Assert.AreEqual(expectedSize, startingSize, "Starting point is not (945, 1020)");
        }

        [TearDown]
        public void CloseChromeAndSesion()
        {
            driver.Close();
            driver.Quit();
        }
    }



    class test1
    {
        IWebDriver driver;

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Position = new Point(445, 30);
            driver.Manage().Window.Size = new Size(854, 480);

        }

        [Test]
        public void Tests()
        {
            Point currentPoint = driver.Manage().Window.Position;
            Size currentSize = driver.Manage().Window.Size;
            Point expectedPoint = new Point(445, 30);
            Size expectedSize = new Size(854, 480);

            Assert.AreEqual(expectedPoint, currentPoint, "Current point is not equal expected point");
            Assert.AreEqual(expectedSize, currentSize, "Current size is not equal expected size");
        }

        [TearDown]
        public void CloseChromeAndSesion()
        {
            driver.Close();
            driver.Quit();
        }
    }
}