using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
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
        private readonly By _drpOperation = By.Id("selectOperationDropdown");

        public IWebElement txtNumber1 => this._driver.FindElement(_txtNumber1);
        public IWebElement txtNumber2 => this._driver.FindElement(_txtNumber2);
        public IWebElement btnCalculate => this._driver.FindElement(_btnCalculate);
        public IWebElement drpOperation => this._driver.FindElement(_drpOperation);


        public void calcular(String op,String num1, String num2)
        {
            txtNumber1.SendKeys(num1);
            txtNumber2.SendKeys(num2);
            var selectElement = drpOperation.FindElement(By.CssSelector("option"));
            var select = new SelectElement(selectElement);
            select.SelectByValue(op);
            btnCalculate.Click();

        }
    }
}
