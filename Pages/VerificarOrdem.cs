using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
