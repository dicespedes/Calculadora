using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using Calculadora.Genericos;
using Calculadora.PageObject.Principal;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Test
{
    public class BaseTest
    {
        public IWebDriver driver;
        public PrincipalPage principal;
        public LeerJson json;
        public TomarCaptura captura;

        //reportes
        public static ExtentTest test;
        public static ExtentReports reports;


        [SetUp]
        public void setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);  //espera implicita
            driver.Manage().Window.Minimize();
            driver.Navigate().GoToUrl("https://testsheepnz.github.io/BasicCalculator.html");
            principal = new PrincipalPage(driver);
            json = new LeerJson();
            captura = new TomarCaptura();
        }
        [TearDown]
        public void teardown()
        {
            driver.Close();
            driver.Quit();
        }
        [OneTimeSetUp] //solo se llama una vez antes del bloque de pruebas
        public void IniciarReporte()
        {
            reports = new ExtentReports();
            ExtentSparkReporter htmlreporter = new ExtentSparkReporter(@"..\..\..\Reportes.html");
            reports.AttachReporter(htmlreporter);
            htmlreporter.Config.Theme = AventStack.ExtentReports.Reporter.Config.Theme.Dark;
            htmlreporter.Config.ReportName = "ReporteCalculadora";

        }
        [OneTimeTearDown]
        public void GenerarReporte()
        {
            reports.Flush();//genere en algo fisico el reporte que tenia en memoria
        }
    }
}
