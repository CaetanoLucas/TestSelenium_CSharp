using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;


namespace ProvaAutomacao.Pages
{
    class Pesquisa
    {
        private IWebDriver driver;

        public Pesquisa(IWebDriver driver)
        {
            this.driver = driver;
        }

        private IWebElement campoPesquisa()
        {
            return driver.FindElement(By.Id("search_query_top"));
        }

        private IWebElement botaoPesquisar()
        {
            return driver.FindElement(By.CssSelector("button[name=submit_search]"));
        }
        public void consultar(string item)
        {
            campoPesquisa().SendKeys(item);
            botaoPesquisar().Click();
        }

        private WebDriverWait esperar()
        {
            return new WebDriverWait(driver, TimeSpan.FromSeconds(30));
        }

        private By contadorDeProduto()
        {
            return By.ClassName("product-count");
        }

        public Boolean validarResultadoDaPesquisa()
        {
            if (esperar().Until(ExpectedConditions.ElementIsVisible(contadorDeProduto())).Displayed)
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