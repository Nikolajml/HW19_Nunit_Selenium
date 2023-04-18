using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;

namespace Nunit_Selenium
{
    [TestFixture]
    public class Dropdown
    {
        WebDriver ChromeDriver { get; set; }

        [SetUp]
        public void Setup()
        {
            ChromeDriver = new ChromeDriver();
            ChromeDriver.Manage().Window.Maximize();
        }

        [Test]
        public void Test_C_Dropdown()
        {
            //ChromeDriver.Navigate().GoToUrl("http://the-internet.herokuapp.com/dropdown");

            //IWebElement dropDown = ChromeDriver.FindElement(By.Id("dropdown"));
            //dropDown.Click();            
        }

        [TearDown]
        public void TearDown()
        {
            ChromeDriver.Quit();
        }
    }
}
