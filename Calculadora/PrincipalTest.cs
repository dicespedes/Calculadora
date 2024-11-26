using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Calculadora
{
    public class Tests
    {
        //[SetUp]
        //public void Setup()
        //{
        //}

        [Test]
        public void Suma()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Minimize();
            driver.Navigate().GoToUrl("https://testsheepnz.github.io/BasicCalculator.html");

            driver.FindElement(By.Id("number1Field")).SendKeys("1");
            driver.FindElement(By.Id("number2Field")).SendKeys("1");
            driver.FindElement(By.Id("calculateButton")).Click();


            driver.Close();
            driver.Quit();
            

            //Assert.Pass();
        }
    }
}