using OpenQA.Selenium;

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
        public void acessarTelaLogin()
        {
            singIn().Click();
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