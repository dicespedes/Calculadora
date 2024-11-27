using Calculadora.PageObject;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Calculadora.Test
{
    public class Tests
    {
        public IWebDriver driver ;
        public PrincipalObject principal;
        [SetUp]
        public void setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Minimize();
            driver.Navigate().GoToUrl("https://testsheepnz.github.io/BasicCalculator.html");
            principal = new PrincipalObject(driver);
        }
        [TearDown]
        public void teardown() 
        {
            driver.Close();
            driver.Quit();
        }

        [Test]
        public void Suma()
        {   
            principal.calcular("1","1","2");//1 para add
            //Assert.Pass();
        }
    }
}