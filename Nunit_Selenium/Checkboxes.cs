using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Nunit_Selenium
{  
    [TestFixture]
    public class Checkboxes
    {
        WebDriver ChromeDriver { get; set; }

        [SetUp]
        public void Setup() 
        {
            ChromeDriver = new ChromeDriver();
            ChromeDriver.Manage().Window.Maximize();
            ChromeDriver.Navigate().GoToUrl("http://the-internet.herokuapp.com/checkboxes");
        }

        [Test]
        public void Test_B_Checkboxes() 
        {                       
            List<IWebElement> elements = ChromeDriver.FindElements(By.CssSelector("[type=checkbox]")).ToList();            
            var checkBox1_Attribut1 = elements[0].GetAttribute("");
            Assert.IsNull(checkBox1_Attribut1);

            elements[0].Click();
            var checkBox1_Attribut2 = elements[0].GetAttribute("checked");
            Assert.IsNotNull(checkBox1_Attribut2);

            var checkBox2_Attribut1 = elements[1].GetAttribute("checked");
            Assert.IsNotNull(checkBox2_Attribut1);

            elements[1].Click();
            var checkBox2_Attribut2 = elements[1].GetAttribute("");
            Assert.IsNull(checkBox2_Attribut2);
        }

        [TearDown] 
        public void TearDown() 
        { 
            ChromeDriver.Quit();
        }
    }
}
