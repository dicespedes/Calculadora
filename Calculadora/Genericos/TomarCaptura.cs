using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Genericos
{
    public class TomarCaptura
    {
        public String CapturarPantalla(IWebDriver driver)
        {
			String photo = "";
			try
			{
				ITakesScreenshot screenshotdriver = driver as ITakesScreenshot;
				Screenshot screenshot = screenshotdriver.GetScreenshot();
				photo = screenshot.AsBase64EncodedString;
            }
			catch (Exception ex)
			{
				Console.WriteLine($"No se pudo guardar la imagen: {ex}");
			}
			return photo;
        }
    }
}
