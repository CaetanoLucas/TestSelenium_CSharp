using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaAutomacao.Pages
{
    class Pagamento
    {
        IWebDriver driver;

        public Pagamento(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void selecionarPagamento()
        {
            formaPagamento().Click();
        }

        public void gerarOrdem()
        {
            seguirParaOrdem().Click();
        }

        private IWebElement formaPagamento()
        {
            return driver.FindElement(By.ClassName("bankwire"));
        }

        private IWebElement seguirParaOrdem()
        {
            return driver.FindElement(By.XPath("//body[1]/div[1]/div[2]/div[1]/div[3]/div[1]/form[1]/p[1]/button[1]/span[1]"));
        }
    }
}
