using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using ProvaAutomacao.Pages;
using System;
using TechTalk.SpecFlow;
using NUnit.Framework;
using ProvaAutomacao.Util;

namespace ProvaAutomacao.Steps
{
    [Binding]
    public class ConsultarRoupaSteps
    {
        string url = "http://automationpractice.com/";
        IWebDriver driver;
        Pesquisa pesquisa;
        Home home;

        [Given(@"eu acesso o site my store")]
        public void DadoEuAcessoOSiteMyStore()
        {
            // iniciar classes
            driver = ManterDriver.iniciarDriver();
            home = new Home(driver);
            pesquisa = new Pesquisa(driver);

            home.acessarSite(url);
        }
        
        [When(@"eu desejar procurar uma camiseta")]
        public void QuandoEuDesejarProcurarUmaCamiseta()
        {
            pesquisa.consultar("dresses");
        }
        
        [Then(@"o site retorna as camisetas disponíveis\.")]
        public void EntaoOSiteRetornaAsCamisetasDisponiveis_()
        {
            Assert.IsTrue(pesquisa.validarResultadoDaPesquisa());
            ManterDriver.FinalizarDriver(driver);
        }
    }
}
