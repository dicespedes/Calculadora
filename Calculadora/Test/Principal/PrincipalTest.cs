using AventStack.ExtentReports;
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
            test = reports.CreateTest("Validando Operaciones");
            var data = json.principal_data();
            try
            {
                test.Log(Status.Info, $"Se estan usando los datos {Numb1} , {Numb2}");
                Assert.That(principal.calcular(Operat, Numb1, Numb2));
                //captura.CapturarPantalla(driver);
                test.AddScreenCaptureFromBase64String(captura.CapturarPantalla(driver));
                test.Log(Status.Pass, $"Se calculo bien");
            }
            catch(NoSuchElementException ex)
            { 
                Console.WriteLine($"No se encontro el elemento: {ex.Message}");
                test.AddScreenCaptureFromBase64String(captura.CapturarPantalla(driver));
                test.Log(Status.Fail, $"Fallo la prueba No se encontro el elemento");
            }
            catch (Exception ex)
            {
                Console.WriteLine ($"error en la ejecucion: {ex.Message}");
                test.AddScreenCaptureFromBase64String(captura.CapturarPantalla(driver));
                test.Log(Status.Fail, $"Fallo la TODO");
            }
            
        }
    }
}