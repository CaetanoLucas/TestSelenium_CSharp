using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ProvaAutomacao.Util
{
    public static class ManterDriver
    {
        [SetUp]
        public static IWebDriver iniciarDriver()
        {
            return new ChromeDriver();
        }

        [TearDown]
        public static void FinalizarDriver(IWebDriver driver)
        {
            driver.Quit();
        }
    }
}
