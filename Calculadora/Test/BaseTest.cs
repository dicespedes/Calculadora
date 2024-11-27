using Calculadora.Genericos;
using Calculadora.PageObject.Principal;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Test
{
    public class BaseTest
    {
        public IWebDriver driver;
        public PrincipalPage principal;
        public LeerJson json;

        [SetUp]
        public void setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Minimize();
            driver.Navigate().GoToUrl("https://testsheepnz.github.io/BasicCalculator.html");
            principal = new PrincipalPage(driver);
            json = new LeerJson();
        }
        [TearDown]
        public void teardown()
        {
            driver.Close();
            driver.Quit();
        }

    }
}
