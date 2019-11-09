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
        }
    }
}
