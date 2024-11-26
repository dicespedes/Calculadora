using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.PageObject
{
    public class PrincipalObject
    {
        public IWebDriver _driver;

        public PrincipalObject(IWebDriver driver)
        {
            this._driver = driver;
        }

        private readonly By _txtNumber1 = By.Id("number1Field");
        private readonly By _txtNumber2 = By.Id("number2Field");
        private readonly By _btnCalculate = By.Id("calculateButton");

        public IWebElement Number1 => this._driver.FindElement(_txtNumber1);
        public IWebElement Number2 => this._driver.FindElement(_txtNumber2);
        public IWebElement btnCalculate => this._driver.FindElement(_btnCalculate);

        public void calcularSuma()
        {
            Number1.SendKeys("1");
            Number2.SendKeys("2");
            btnCalculate.Click();

        }
    }
}
