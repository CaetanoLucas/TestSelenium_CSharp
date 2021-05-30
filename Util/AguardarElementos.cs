using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaAutomacao.Util
{
    class AguardarElementos
    {
        private WebDriverWait esperar(IWebDriver driver)
        {
            return new WebDriverWait(driver, TimeSpan.FromSeconds(30));
        }

        public Boolean AguardarElementoVisivel(By elemento, IWebDriver driver)
        {
            if (esperar(driver).Until(ExpectedConditions.ElementIsVisible(elemento)).Displayed)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
