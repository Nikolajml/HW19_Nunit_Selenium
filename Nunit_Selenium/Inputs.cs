using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;


namespace Nunit_Selenium
{
    public class Inputs
    {
        WebDriver ChromeDriver { get; set; }

        [SetUp]
        public void Setup()
        {
            ChromeDriver = new ChromeDriver();
            ChromeDriver.Manage().Window.Maximize();
        }

        [Test]
        public void Test_D_ArrowUp()
        {
            ChromeDriver.Navigate().GoToUrl("http://the-internet.herokuapp.com/inputs");

            IWebElement input = ChromeDriver.FindElement(By.TagName("input"));
            input.SendKeys(Keys.ArrowUp);
            input.SendKeys(Keys.ArrowUp);

            var result1 = ChromeDriver.FindElement(By.TagName("input")).GetAttribute("value");
            Assert.That("2", Is.EqualTo(result1));            
        }

        [Test]
        public void Test_D_ArrowDown()
        {
            ChromeDriver.Navigate().GoToUrl("http://the-internet.herokuapp.com/inputs");

            IWebElement input = ChromeDriver.FindElement(By.TagName("input"));
            input.SendKeys(Keys.ArrowDown);
            input.SendKeys(Keys.ArrowDown);
            input.SendKeys(Keys.ArrowDown);

            var result = ChromeDriver.FindElement(By.TagName("input")).GetAttribute("value");
            Assert.That("-3", Is.EqualTo(result));
        }

        [TearDown]
        public void TearDown()
        {
            ChromeDriver.Quit();
        }
    }
}
