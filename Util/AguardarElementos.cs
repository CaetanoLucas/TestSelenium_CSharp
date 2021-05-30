using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;


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
