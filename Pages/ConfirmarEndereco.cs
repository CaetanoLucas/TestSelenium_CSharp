using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public void verificarCarrinho()
        {
            carrinho().Click();
        }

        public void verificarItensESeguir()
        {
            seguirParaEndereco().Click();
        }

        private IWebElement seguirParaTermos()
        {
            return driver.FindElement(By.XPath("//body[1]/div[1]/div[2]/div[1]/div[3]/div[1]/form[1]/p[1]/button[1]/span[1]"));
        }

        public void verificarEnderecoESeguir()
        {
            seguirParaTermos().Click();
        }
    }
}
