using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaAutomacao.Pages
{
    class FazerLogin
    {
        private IWebDriver driver;

        public FazerLogin(IWebDriver driver)
        {
            this.driver = driver;
        }

        private IWebElement singIn()
        {
            return driver.FindElement(By.ClassName("login"));
        }
        public void acessarTelaLogin()
        {
            singIn().Click();
        }

        private IWebElement campoEmail()
        {
            return driver.FindElement(By.Id("email"));
        }
        private IWebElement campoSenha()
        {
            return driver.FindElement(By.Id("passwd"));
        }

        private IWebElement botaoLogin()
        {
            return driver.FindElement(By.Id("SubmitLogin"));
        }
        public void informarEmail(string email)
        {
            campoEmail().SendKeys(email);
        }

        public void informarSenha(string senha)
        {
            campoSenha().SendKeys(senha);
        }
        public void realizarLogin()
        {
            botaoLogin().Click();
        }
    }
}