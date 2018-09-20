using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using waitHelpers = SeleniumExtras.WaitHelpers;

namespace Atari
{
    public class SeguimientoPaquetesGeneralPage : BasePage
    {
        public SeguimientoPaquetesGeneralPage(IWebDriver webDriver) : base(webDriver)
        {
        }
        public void Usuario(string user)
        {
            var usuario = Wait.Until(waitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("/html/body/app-root/app-login/div/div/form/div/div[2]/span/input")));
            usuario.Clear();
            usuario.SendKeys(user);

        }
        public void Password(string pass)
        {
            var contra = Wait.Until(waitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("/html/body/app-root/app-login/div/div/form/div/div[3]/span/input")));
            contra.Clear();
            contra.SendKeys(pass);

        }
        public void Ingresar()
        {
            var ingresar = Wait.Until(waitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("/html/body/app-root/app-login/div/div/form/div/div[4]/button")));
            ingresar.Click();
        }
        public void AbriMenu()
        {
            var menu = Wait.Until(waitHelpers.ExpectedConditions.ElementIsVisible(By.Id("menu-button")));
            menu.Click();
        }
        public void ModuloEmpresa()
        {
            var empresa = Wait.Until(waitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("/html/body/app-root/app-main/div/div/div[1]/div/div[1]/app-menu/ul/li[5]/a")));
            empresa.Click();
        }
        public void Seguimiento()
        {
            var seguimiento = Wait.Until(waitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("/html/body/app-root/app-main/div/div/div[1]/div/div[1]/app-menu/ul/li[5]/ul/li[3]/a")));
            seguimiento.Click();
        }
        public void SeleccionarEmpresa()
        {
            try
            {
                var empresa = Wait.Until(waitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("/html/body/app-root/app-main/div/div/div[2]/app-user-depot-seguimiento/p-panel/div/div[1]/p-header/div/div[2]/p-dropdown/div")));
                Thread.Sleep(2000);
                empresa.Click();
                var nombre = Wait.Until(waitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("/html/body/app-root/app-main/div/div/div[2]/app-user-depot-seguimiento/p-panel/div/div[1]/p-header/div/div[2]/p-dropdown/div/div[3]/div[1]/input")));
                Thread.Sleep(200);
                nombre.SendKeys("NESPRESSO");
                Thread.Sleep(200);
                nombre.SendKeys(Keys.ArrowDown);
                Thread.Sleep(200);
                nombre.SendKeys(Keys.Enter);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void Sucursal()
        {
            try
            {
                var sucursal = Wait.Until(waitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='ui-panel-0']/div[1]/p-header/div/div[1]")));
                Thread.Sleep(2000);
                sucursal.Click();
                var all = Wait.Until(waitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='ui-panel-0']/div[1]/p-header/div/div[1]/p-multiselect/div/div[4]/div[1]/div[1]/div[2]")));
                Thread.Sleep(2000);
                all.Click();
                var cerrar = Wait.Until(waitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='ui-panel-0']/div[1]/p-header/div/div[1]/p-multiselect/div/div[4]/div[1]/a")));
                Thread.Sleep(2000);
                cerrar.Click();
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void ReporteGeneral()
        {
              var general = Wait.Until(waitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("/html/body/app-root/app-main/div/div/div[2]/app-user-depot-seguimiento/p-panel/div/div[2]/div/p-tabview/div/ul/li[1]")));
            general.Click();
        }
        public void Fechas()
        {
            var inicio = Wait.Until(waitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("/html/body/app-root/app-main/div/div/div[2]/app-user-depot-seguimiento/p-panel/div/div[2]/div/p-tabview/div/div/p-tabpanel[1]/div/div/div[1]/p-calendar/span/input")));
            Thread.Sleep(1000);
            inicio.Click();
            Thread.Sleep(1000);
            inicio.SendKeys(Keys.Control+"A");
            inicio.SendKeys(Keys.Backspace);
            Thread.Sleep(1000);
            inicio.SendKeys("10/09/2018");
            Thread.Sleep(1000);
            inicio.SendKeys(Keys.Tab);
            /*var ingresarFechaInicio = new Actions(Driver);
            ingresarFechaInicio.Click(inicio);
            ingresarFechaInicio.SendKeys(inicio, "10/09/2017");
            ingresarFechaInicio.Build().Perform();*/

            Thread.Sleep(1000);

            var fin = Wait.Until(waitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("/html/body/app-root/app-main/div/div/div[2]/app-user-depot-seguimiento/p-panel/div/div[2]/div/p-tabview/div/div/p-tabpanel[1]/div/div/div[2]/p-calendar/span/input")));
            Thread.Sleep(1000);
            fin.Click();
            Thread.Sleep(1000);
            fin.SendKeys(Keys.Control+"A");
            fin.SendKeys(Keys.Backspace);
            Thread.Sleep(1000);
            fin.SendKeys("17/09/2018");

            var buscarButton = Wait.Until(waitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("/html/body/app-root/app-main/div/div/div[2]/app-user-depot-seguimiento/p-panel/div/div[2]/div/p-tabview/div/div/p-tabpanel[1]/div/div/div[3]/button[1]")));
            buscarButton.Click();
            Thread.Sleep(2000);
            var exportar =Wait.Until(waitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("/html/body/app-root/app-main/div/div/div[2]/app-user-depot-seguimiento/p-panel/div/div[2]/div/p-tabview/div/div/p-tabpanel[1]/div/div/div[3]/button[2]")));
            Thread.Sleep(500);
            exportar.Click();
            var yes = Wait.Until(waitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("/html/body/app-root/app-main/div/div/div[2]/app-user-depot-seguimiento/p-confirmdialog/div/div[3]/button[1]")));
            yes.Click();
            Thread.Sleep(500);
            //FirefoxProfile firefoxProfile = new FirefoxProfile();
            //firefoxProfile.SetPreference("browser.helperApps.neverAsk.saveToDisk", "application/octet-stream doc xls pdf txt");
            /*codigo que eliminar ventana de descarga*/
            // creating instance of Robot class (A java based utility
              }

        public SeguimientoPaquetesGeneralPage LoginSeguimientoPaqueGeneral(string usuario,string pass)
        {
            Usuario(usuario);
            Thread.Sleep(1000);
            Password(pass);
            Thread.Sleep(1000);
            Ingresar();
            Thread.Sleep(1000);
            AbriMenu();
            Thread.Sleep(1000);
            ModuloEmpresa();
            Seguimiento();
            Thread.Sleep(2000);
            SeleccionarEmpresa();
            Thread.Sleep(2000);
            Sucursal();
            Thread.Sleep(2000);
            ReporteGeneral();
            Thread.Sleep(2000);
            Fechas();
            Thread.Sleep(2000);

            return new  SeguimientoPaquetesGeneralPage(Driver);

        }

        
    }
}
