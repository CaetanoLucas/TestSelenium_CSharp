using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public void verificarDetalhes()
        {
            detalheProduto().Click();
        }

        private IWebElement botaoAdicionar()
        {
            return driver.FindElement(By.Id("add_to_cart"));
        }
        public void adicionarProduto()
        {
            botaoAdicionar().Click();
        }
        private IWebElement fecharJanela()
        {
            return driver.FindElement(By.ClassName("cross"));
        }

        public By fecharJanelaWait()
        {
            return By.ClassName("cross");
        }

        public void prosseguir()
        {
            fecharJanela().Click();
        }


    }
}