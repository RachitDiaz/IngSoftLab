using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace UIAutomationTests
{
    class Selenium
    {
        IWebDriver _driver;

        [SetUp]
        public void Setup()
        {
            _driver = new OpenQA.Selenium.Chrome.ChromeDriver();
            _driver.Manage().Window.Maximize();
        }

        [Test]
        public void Get_Countries_And_Add_Country()
        {
            var URL = "http://localhost:8080/";

            //Act
            _driver.Navigate().GoToUrl(URL);



            var botonAgregar = _driver.FindElement(By.XPath("//a[@href='/pais']"));
            botonAgregar.Click();

            Thread.Sleep(1000);

            _driver.FindElement(By.Id("name")).SendKeys("Prueba");
            _driver.FindElement(By.Id("continente")).SendKeys("América");
            _driver.FindElement(By.Id("idioma")).SendKeys("Testingsh");


            _driver.FindElement(By.CssSelector("button[type='submit']")).Click();
            Thread.Sleep(3000);
            //Assert
            var tabla = _driver.FindElement(By.TagName("table"));
            Assert.IsTrue(tabla.Text.Contains("Prueba"));
        }
    }
}
