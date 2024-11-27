using Calculadora.Genericos;
using Calculadora.PageObject.Principal;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Calculadora.Test.Principal
{
    public class Tests : BaseTest
    {
        [Test]
        public void Suma()
        {
            var data = json.principal_data();
            principal.calcular(data.Operation, data.Number1, data.Number2);//1 para add
            //Assert.Pass();
        }
    }
}