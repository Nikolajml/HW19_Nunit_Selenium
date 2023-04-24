using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace Nunit_Selenium
{
    public class AddRemoveElements
    {
        WebDriver ChromeDriver { get; set; }

        [SetUp]
        public void Setup()
        {
            ChromeDriver = new ChromeDriver();
            ChromeDriver.Manage().Window.Maximize();
            ChromeDriver.Navigate().GoToUrl("http://the-internet.herokuapp.com/add_remove_elements/");
        }

        [Test]
        public void Test_A_Add_Remove_Elements()
        {                           
            IWebElement element = ChromeDriver.FindElement(By.XPath("//button[text()='Add Element']"));
            element.Click();
            element.Click();            

            ChromeDriver.FindElement(By.XPath("//button[text()='Delete']")).Click();

            var elements = ChromeDriver.FindElements(By.XPath("//button[text()='Delete']"));

            foreach (var e in elements)
            {
                Console.WriteLine(e);
            }

            Assert.True(elements.Any());
        }

        [TearDown]
        public void TearDown()
        {
            Console.WriteLine("Test completed");
            ChromeDriver.Quit();
        }
    }
}