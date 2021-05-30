using OpenQA.Selenium;


namespace ProvaAutomacao.Pages
{
    class Pesquisa
    {
        private IWebDriver driver;

        public Pesquisa(IWebDriver driver)
        {
            this.driver = driver;
        }

        private IWebElement campoPesquisa()
        {
            return driver.FindElement(By.Id("search_query_top"));
        }

        private IWebElement botaoPesquisar()
        {
            return driver.FindElement(By.CssSelector("button[name=submit_search]"));
        }
        public void consultar(string item)
        {
            campoPesquisa().SendKeys(item);
            botaoPesquisar().Click();
        }
    }
}