using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nunit_Selenium
{
    internal class Typos
    {
        WebDriver ChromeDriver { get; set; }

        [SetUp]
        public void Setup()
        {
            ChromeDriver = new ChromeDriver();
            ChromeDriver.Manage().Window.Maximize();
        }

        [Test]
        public void Test_F_Typos_part1()
        {
            ChromeDriver.Navigate().GoToUrl("http://the-internet.herokuapp.com/typos");

            var textPart1 = ChromeDriver.FindElement(By.TagName("p"));
            var actualResultPart1 = textPart1.Text;

            var expectedResultPart1 = "This example demonstrates a typo being introduced. It does it randomly on each page load.";
            
            Assert.That(actualResultPart1, Is.EqualTo(expectedResultPart1));            
        }

        [Test]
        public void Test_F_Typos_part2()
        {
            ChromeDriver.Navigate().GoToUrl("http://the-internet.herokuapp.com/typos");

            var textPart2 = ChromeDriver.FindElement(By.XPath($"//p[2]"));
            var actualResultPart2 = textPart2.Text;

            var expectedResultPart2 = "Sometimes you'll see a typo, other times you won't.";

            Assert.That(actualResultPart2, Is.EqualTo(expectedResultPart2));
        }

        [TearDown]
        public void TearDown()
        {
            ChromeDriver.Quit();
        }
    }
}
