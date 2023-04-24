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
            ChromeDriver.Navigate().GoToUrl("http://the-internet.herokuapp.com/dropdown");
        }

        [Test]
        public void Test_C_Dropdown()
        {
            IWebElement dropdown = ChromeDriver.FindElement(By.Id("dropdown"));
            dropdown.Click();
            List<IWebElement> elements = ChromeDriver.FindElements(By.TagName("option")).ToList();

            foreach (IWebElement element in elements)
            {
                var displayed = element.Displayed;
                Assert.IsTrue(displayed);
            }

            SelectElement selected = new SelectElement(ChromeDriver.FindElement(By.Id("dropdown")));

            selected.SelectByText("Option 1");
            IWebElement element1 = ChromeDriver.FindElement(By.XPath("//option[@value='1']"));
            var resultElement1 = element1.GetAttribute("selected");
            Assert.IsNotNull(resultElement1);

            selected.SelectByText("Option 2");
            IWebElement element2 = ChromeDriver.FindElement(By.XPath("//option[@value='2']"));
            var resultElement2 = element2.GetAttribute("selected");
            Assert.IsNotNull(resultElement2);
        }

        [TearDown]
        public void TearDown()
        {
            ChromeDriver.Quit();
        }
    }
}
