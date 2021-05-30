using OpenQA.Selenium;

namespace ProvaAutomacao.Pages
{
    class AddProdutoCarrinho
    {
        private IWebDriver driver;

        public AddProdutoCarrinho(IWebDriver driver)
        {
            this.driver = driver;
        }

        public By detalheProdutoWait()
        {
            return By.XPath("//body/div[@id='page']/div[2]/div[1]/div[3]/div[2]/ul[1]/li[1]/div[1]/div[1]/div[1]/a[1]/img[1]");
        }

        private IWebElement detalheProduto()
        {
            return driver.FindElement(By.XPath("//body/div[@id='page']/div[2]/div[1]/div[3]/div[2]/ul[1]/li[1]/div[1]/div[1]/div[1]/a[1]/img[1]"));
        }

        private IWebElement fecharJanela()
        {
            return driver.FindElement(By.ClassName("cross"));
        }

        public By fecharJanelaWait()
        {
            return By.ClassName("cross");
        }

        private IWebElement botaoAdicionar()
        {
            return driver.FindElement(By.Id("add_to_cart"));
        }

        public void verificarDetalhes()
        {
            detalheProduto().Click();
        }
        
        public void adicionarProduto()
        {
            botaoAdicionar().Click();
        }

        public void prosseguir()
        {
            fecharJanela().Click();
        }
    }
}