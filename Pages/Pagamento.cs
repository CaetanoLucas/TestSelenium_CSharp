using OpenQA.Selenium;


namespace ProvaAutomacao.Pages
{
    class Pagamento
    {
        IWebDriver driver;

        public Pagamento(IWebDriver driver)
        {
            this.driver = driver;
        }

        private IWebElement formaPagamento()
        {
            return driver.FindElement(By.ClassName("bankwire"));
        }

        private IWebElement seguirParaOrdem()
        {
            return driver.FindElement(By.XPath("//body[1]/div[1]/div[2]/div[1]/div[3]/div[1]/form[1]/p[1]/button[1]/span[1]"));
        }

        public void selecionarPagamento()
        {
            formaPagamento().Click();
        }

        public void gerarOrdem()
        {
            seguirParaOrdem().Click();
        }
    }
}
