using NUnit.Framework;
using OpenQA.Selenium;
using ProvaAutomacao.Pages;
using ProvaAutomacao.Util;
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
        AceitarTermos aceitarTermos;
        Pagamento pagamento;
        VerificarOrdem verificarOrdem;

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
            aceitarTermos = new AceitarTermos(driver);
            pagamento = new Pagamento(driver);
            verificarOrdem = new VerificarOrdem(driver);

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
            if (aguardar.AguardarElementoVisivel(addProduto.detalheProdutoWait(), driver))
                addProduto.verificarDetalhes();
            
            addProduto.adicionarProduto();
            
            if (aguardar.AguardarElementoVisivel(addProduto.fecharJanelaWait(), driver))
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

        [When(@"aceitar os termos")]
        public void QuandoAceitarOsTermos()
        {
            aceitarTermos.aceitarTermos();
            aceitarTermos.seguirParaPagamento();
        }

        [When(@"escolher a forma de pagamento")]
        public void QuandoEscolherAFormaDePagamento()
        {
            pagamento.selecionarPagamento();
            pagamento.gerarOrdem();
        }

        [Then(@"o site retorna a ordem completa")]
        public void EntaoOSiteRetornaAOrdemCompleta()
        {
            bool ordemGerada = false;

            if (aguardar.AguardarElementoVisivel(verificarOrdem.ordemGerada(), driver))
            {
                ordemGerada = true;
            }
            Assert.IsTrue(ordemGerada);
            
            ManterDriver.FinalizarDriver(driver);
        }
    }
}