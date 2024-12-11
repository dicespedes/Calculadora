using NUnit.Framework.Constraints;
using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V130.CSS;
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
        private readonly By _txtResultado = By.Id("numberAnswerField");

        public IWebElement txtNumber1 => _driver.FindElement(_txtNumber1);
        public IWebElement txtNumber2 => _driver.FindElement(_txtNumber2);
        public IWebElement btnCalculate => _driver.FindElement(_btnCalculate);
        public IWebElement drpOperation => _driver.FindElement(_drpOperation);
        public IWebElement txtResultado => _driver.FindElement(_txtResultado);

        private string operacion(string Ope, string nu1, string nu2)
        {
            return Ope switch
            {
                "0" => (Convert.ToDouble(nu1) + Convert.ToDouble(nu2)).ToString(),
                "1" => (Convert.ToDouble(nu1) - Convert.ToDouble(nu2)).ToString(),
                "2" => (Convert.ToDouble(nu1) * Convert.ToDouble(nu2)).ToString(),
                "3" => (Convert.ToDouble(nu1) / Convert.ToDouble(nu2)).ToString(),
                "4" => (nu1 + nu2),
                _ => ""
            };            
        }

        public bool calcular(string op, string num1, string num2)
        {
            txtNumber1.SendKeys(num1);
            txtNumber2.SendKeys(num2);
            //var selectElement = drpOperation.FindElement(By.Id("selectOperationDropdown"));
             var select = new SelectElement(drpOperation);
            select.SelectByValue(op);
            btnCalculate.Click();
            //double temporal = (Convert.ToDouble(num1) + Convert.ToDouble(num2));
            string data = ValorResultado();
            string res = this.operacion(op, num1, num2);
            return data.Equals(res);
        }
        public string ValorResultado()
        {
            return this.txtResultado.Text;
        }
    }
}
