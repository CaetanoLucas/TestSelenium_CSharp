using OpenQA.Selenium;
using ProvaAutomacao.Pages;
using ProvaAutomacao.Util;
using System;
using TechTalk.SpecFlow;

namespace ProvaAutomacao.Steps
{
    [Binding]
    public class RealizarCompra_Steps
    {
        string url = "http://automationpractice.com/";
        IWebDriver driver;
        Pesquisa pesquisa;
        Home home;
        AddProdutoCarrinho addProduto;
        AguardarElementos aguardar;
        FazerLogin fazerLogin;
        ConfirmarEndereco confirmarEndereco;

        [Given(@"que eu acesse o site my store")]
        public void DadoQueEuAcesseOSiteMyStore()
        {
            driver = ManterDriver.iniciarDriver();
            home = new Home(driver);
            pesquisa = new Pesquisa(driver);
            addProduto = new AddProdutoCarrinho(driver);
            aguardar = new AguardarElementos();
            fazerLogin = new FazerLogin(driver);
            confirmarEndereco = new ConfirmarEndereco(driver);

            home.acessarSite(url);
        }

        [When(@"eu procurar por um produto")]
        public void QuandoEuProcurarPorUmProduto()
        {
            pesquisa.consultar("Blouse");
        }

        [When(@"adicionar este produto no carrinho")]
        public void QuandoAdicionarEsteProdutoNoCarrinho()
        {
            if (aguardar.AguardarElementoVisivel(addProduto.detalheProdutoWait(), driver)) ;
            addProduto.verificarDetalhes();
            addProduto.adicionarProduto();
            if (aguardar.AguardarElementoVisivel(addProduto.fecharJanelaWait(), driver)) ;
            addProduto.prosseguir();
        }

        [When(@"efetuar login")]
        public void QuandoEfetuarLogin()
        {
            fazerLogin.acessarTelaLogin();
            fazerLogin.informarEmail("caetanolucas1912@gmail.com");
            fazerLogin.informarSenha("senhaDeTeste");
            fazerLogin.realizarLogin();
        }

        [When(@"confirmar o endereço")]
        public void QuandoConfirmarOEndereco()
        {
            confirmarEndereco.verificarCarrinho();
            confirmarEndereco.verificarItensESeguir();
            confirmarEndereco.verificarEnderecoESeguir();
        }

        //[When(@"aceitar os termos")]
        //public void QuandoAceitarOsTermos()
        //{
        //    ScenarioContext.Current.Pending();
        //}

        //[When(@"escolher a forma de pagamento")]
        //public void QuandoEscolherAFormaDePagamento()
        //{
        //    ScenarioContext.Current.Pending();
        //}

        //[Then(@"o site retorna a ordem completa")]
        //public void EntaoOSiteRetornaAOrdemCompleta()
        //{
        //    ScenarioContext.Current.Pending();
        //}
    }
}