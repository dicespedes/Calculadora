using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Calculadora
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Minimize();
            driver.Navigate().GoToUrl("https://testsheepnz.github.io/BasicCalculator.html");

            //Assert.Pass();
        }
    }
}