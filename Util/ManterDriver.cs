using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
