using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaAutomacao.Pages
{
    class AceitarTermos
    {
        IWebDriver driver;

        public AceitarTermos(IWebDriver driver)
        {
            this.driver = driver;
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

        private IWebElement seguir()
        {
            return driver.FindElement(By.XPath("//body[1]/div[1]/div[2]/div[1]/div[3]/div[1]/div[1]/form[1]/p[1]/button[1]/span[1]"));
        }
    }
}
