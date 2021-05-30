using OpenQA.Selenium;

namespace ProvaAutomacao.Pages
{
    class AceitarTermos
    {
        IWebDriver driver;

        public AceitarTermos(IWebDriver driver)
        {
            this.driver = driver;
        }

        //Precisei utilizar alguns XPaths por falta de elementos mais seguros para a automação.
        // Acredito que seria possivel utilizar outra alternativa mas por falta de tempo mantive o XPath.
        private IWebElement seguir()
        {
            return driver.FindElement(By.XPath("//body[1]/div[1]/div[2]/div[1]/div[3]/div[1]/div[1]/form[1]/p[1]/button[1]/span[1]"));
        }

        public void aceitarTermos()
        {
            checkTermos().Click();
        }

        public void seguirParaPagamento()
        {
            seguir().Click();
        }

        private IWebElement checkTermos()
        {
            return driver.FindElement(By.Id("cgv"));
        }
    }
}
