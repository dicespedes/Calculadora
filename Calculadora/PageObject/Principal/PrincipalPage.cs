using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.PageObject.Principal
{
    public class PrincipalPage: BasePage
    {
       
        public PrincipalPage(IWebDriver driver): base(driver)
        {

        }
        private readonly By _txtNumber1 = By.Id("number1Field");
        private readonly By _txtNumber2 = By.Id("number2Field");
        private readonly By _btnCalculate = By.Id("calculateButton");
        private readonly By _drpOperation = By.Id("selectOperationDropdown");

        public IWebElement txtNumber1 => _driver.FindElement(_txtNumber1);
        public IWebElement txtNumber2 => _driver.FindElement(_txtNumber2);
        public IWebElement btnCalculate => _driver.FindElement(_btnCalculate);
        public IWebElement drpOperation => _driver.FindElement(_drpOperation);


        public void calcular(string op, string num1, string num2)
        {
            txtNumber1.SendKeys(num1);
            txtNumber2.SendKeys(num2);
            //var selectElement = drpOperation.FindElement(By.CssSelector("option"));
            //var select = new SelectElement(selectElement);
            //select.SelectByValue(op);
            btnCalculate.Click();

        }
    }
}
