using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace SeleniumProject
{
    public class Tests
    {
        public ChromeDriver ChromeDriver { get; private set; }

        [SetUp]
        public void Setup()
        {
            Console.WriteLine("Setup");
            ChromeDriver = new ChromeDriver();
        }

        [Test]
        public void Test1()
        {
            ChromeDriver.Navigate().GoToUrl("https://www.yahoo.com");
            ChromeDriver.FindElement(By.ClassName("_yb_demnt")).SendKeys("News");
            ChromeDriver.FindElement(By.Id("ybar-search")).Click();
 

        }
    }
}