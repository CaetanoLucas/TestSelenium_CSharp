using OpenQA.Selenium;

namespace ProvaAutomacao.Pages
{
    class ConfirmarEndereco
    {
        private IWebDriver driver;

        public ConfirmarEndereco(IWebDriver driver)
        {
            this.driver = driver;
        }

        private IWebElement carrinho()
        {
            return driver.FindElement(By.XPath("//header/div[3]/div[1]/div[1]/div[3]/div[1]/a[1]"));
        }

        private IWebElement seguirParaEndereco()
        {
            return driver.FindElement(By.XPath("//body[1]/div[1]/div[2]/div[1]/div[3]/div[1]/p[2]/a[1]/span[1]"));
        }

        private IWebElement seguirParaTermos()
        {
            return driver.FindElement(By.XPath("//body[1]/div[1]/div[2]/div[1]/div[3]/div[1]/form[1]/p[1]/button[1]/span[1]"));
        }

        public void verificarCarrinho()
        {
            carrinho().Click();
        }

        public void verificarItensESeguir()
        {
            seguirParaEndereco().Click();
        }

        public void verificarEnderecoESeguir()
        {
            seguirParaTermos().Click();
        }
    }
}
