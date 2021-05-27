
using OpenQA.Selenium;

namespace ProvaAutomacao.Pages
{
    class Home
    {
        private IWebDriver driver;

        public Home(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void acessarSite(string url)
        {
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(url);
        }
    }
}