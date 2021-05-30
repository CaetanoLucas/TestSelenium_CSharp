using OpenQA.Selenium;

namespace ProvaAutomacao.Pages
{
    class VerificarOrdem
    {
        IWebDriver driver;

        public VerificarOrdem(IWebDriver driver)
        {
            this.driver = driver;
        }

        public By ordemGerada()
        {
            return By.Id("order-confirmation");
        }
    }
}
