using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Projeto.Teste._02.Steps
{
    [Binding]
    public class AcessarContaSteps
    {
        private readonly IWebDriver driver;

        public AcessarContaSteps()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        [Given(@"Acessar a página de login de cliente")]
        public void DadoAcessarAPaginaDeLoginDeCliente()
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"Informar o email ""(.*)""")]
        public void DadoInformarOEmail(string p0)
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"Informar a senha ""(.*)""")]
        public void DadoInformarASenha(int p0)
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"Solciitar a realização do acesso")]
        public void QuandoSolciitarARealizacaoDoAcesso()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"Sistema exibe área restrita do cliente")]
        public void EntaoSistemaExibeAreaRestritaDoCliente()
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"Informar a senha ""(.*)""")]
        public void DadoInformarASenha(string p0)
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"Sistema exibe mensagem ""(.*)""")]
        public void EntaoSistemaExibeMensagem(string p0)
        {
            ScenarioContext.Current.Pending();
        }

    }
}
