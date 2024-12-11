using Calculadora.Genericos;
using Calculadora.PageObject.Principal;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Collections;

namespace Calculadora.Test.Principal
{
    [TestFixture]
    public class Tests : BaseTest
    {
        public static IEnumerable TestData
        {
            get
            {
                var json = new LeerJson();
                return json.principal_data().Select(data => new TestCaseData(data.Number1, data.Number2, data.Operation));
            }
        }

        [TestCaseSource(nameof(TestData))]
        public void ValidaOperaciones( String Numb1, String Numb2, String Operat)
        {
            var data = json.principal_data();
            try
            {
                Assert.That(principal.calcular(Operat, Numb1, Numb2));
            }
            catch(NoSuchDriverException ex)
            { 
                Console.WriteLine($"No se encontro el elemento: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine ($"error en la ejecucion: {ex.Message}");
            }
            
        }
    }
}