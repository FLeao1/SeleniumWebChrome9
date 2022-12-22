using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWebChrome9.Navegadores
{

    public class AbrirSindOnibus
    {
        public IWebDriver driver;

        public static void Main()
        {
            var web = new AbrirSindOnibus();
            web.AbrirSindOnibusVte();
        }

        public AbrirSindOnibus()
        {
            driver = new ChromeDriver();
        }

        public void AbrirSindOnibusVte()
        {
            //Abrir o navegador.
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.google.com");

            ////Ditar o login.
            //driver.FindElement(By.Name("txtCNPJ")).SendKeys("01434589001332");
            ////Digitar a senha.
            //driver.FindElement(By.XPath("//*[@id=\'txtSenha\']")).SendKeys("apel13");
            
            ////Clicar em Continuar.
            //var text = driver.FindElements(By.XPath("//*[@id=\'btnAutenticar\']")).Text;


            //return text;
        }

    }
}
