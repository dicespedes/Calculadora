using Calculadora.Genericos;
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
        public LeerJson json;
        [SetUp]
        public void setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Minimize();
            driver.Navigate().GoToUrl("https://testsheepnz.github.io/BasicCalculator.html");
            principal = new PrincipalObject(driver);
            json = new LeerJson();
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
            var data = json.principal_data();
            principal.calcular(data.Operation, data.Number1, data.Number2);//1 para add
            //Assert.Pass();
        }
    }
}