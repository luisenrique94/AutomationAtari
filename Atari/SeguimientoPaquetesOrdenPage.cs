using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using waitHelpers = SeleniumExtras.WaitHelpers;

namespace Atari
{
    public class SeguimientoPaquetesOrdenPage : BasePage
    {
        public SeguimientoPaquetesOrdenPage(IWebDriver webDriver) : base(webDriver)
        {
        }
        public void Usuario(string user)
        {
            var usuario = Wait.Until(waitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("/html/body/app-root/app-login/div/div/form/div/div[2]/span/input")));
            usuario.Clear();
            usuario.SendKeys(user);
            //hola 
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
            var seguimiento= Wait.Until(waitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("/html/body/app-root/app-main/div/div/div[1]/div/div[1]/app-menu/ul/li[5]/ul/li[3]/a")));
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
        public void IngresarCodigo()
        {
            var trackcode=Wait.Until(waitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("/html/body/app-root/app-main/div/div/div[2]/app-user-depot-seguimiento/p-panel/div/div[2]/div/p-tabview/div/div/p-tabpanel[2]/div/div/div[1]/input")));
            Thread.Sleep(2000);
          //  trackcode.Click();
            //Thread.Sleep(2000);
            trackcode.SendKeys("AUTOMATION__V1_1");           
          }
        public void Buscar()
        {
            var buscar = Wait.Until(waitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("/html/body/app-root/app-main/div/div/div[2]/app-user-depot-seguimiento/p-panel/div/div[2]/div/p-tabview/div/div/p-tabpanel[2]/div/div/div[2]/button")));
            buscar.Click();
        }
        public void Galeria()
        {
            var galeria = Wait.Until(waitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='ui-tabpanel-0']/div[2]/div/p-datatable/div/div[2]/table/tbody/tr[7]/td[1]/span/button")));
            galeria.Click();
            galeria.SendKeys(Keys.PageDown);
        }
        public void Scroll()
        {
            IJavaScriptExecutor je = (IJavaScriptExecutor)Driver;
            var scroll1 = Wait.Until(waitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/app-root/app-main/div/div/div[2]/app-user-depot-seguimiento/p-dialog[2]/div/div[2]/div/div/div/div[1]/div")));
            je.ExecuteScript("arguments[0].scrollIntoView(true);",scroll1);
            je.ExecuteScript("arguments[0].click();", scroll1);
            Thread.Sleep(2000);
            var scroll2= Wait.Until(waitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/app-root/app-main/div/div/div[2]/app-user-depot-seguimiento/p-dialog[2]/div/div[2]/div/div/div/div[2]/div")));
            je.ExecuteScript("arguments[0].scrollIntoView(true);", scroll2);
            je.ExecuteScript("arguments[0].click();", scroll2);
            Thread.Sleep(2000);
            var scroll3 = Wait.Until(waitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/app-root/app-main/div/div/div[2]/app-user-depot-seguimiento/p-dialog[2]/div/div[2]/div/div/div/div[3]/div")));
            je.ExecuteScript("arguments[0].scrollIntoView(true);", scroll3);
            je.ExecuteScript("arguments[0].click();", scroll3);
            Thread.Sleep(2000);
            var scroll4 = Wait.Until(waitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/app-root/app-main/div/div/div[2]/app-user-depot-seguimiento/p-dialog[2]/div/div[2]/div/div/div/div[4]/div")));
            je.ExecuteScript("arguments[0].scrollIntoView(true);", scroll4);
            je.ExecuteScript("arguments[0].click();", scroll4);
            Thread.Sleep(2000);
        }
        public void CerrarGaleria()
        {

            var cerrar = Wait.Until(waitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("/html/body/app-root/app-main/div/div/div[2]/app-user-depot-seguimiento/p-dialog[2]/div/div[1]/a")));
            cerrar.Click();
        }
        public void Pdf() {
            FirefoxProfile profile = new FirefoxProfile();
            //profile.SetPreference("browser.download.folderList", 0);
            // profile.SetPreference("browser.download.panel.shown", false);
          
            var pdf1 = Wait.Until(waitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("/html/body/app-root/app-main/div/div/div[2]/app-user-depot-seguimiento/p-panel/div/div[2]/div/p-tabview/div/div/p-tabpanel[2]/div/div[2]/div/p-datatable/div/div[2]/table/tbody/tr[7]/td[2]/span/div/button[1]")));
            profile.SetPreference("browser.download.folderList", 0);
            pdf1.Click();
            profile.SetPreference("browser.download.panel.shown", false);
            
            //IAlert alert = Driver.SwitchTo().Alert();
           // alert.Accept();
            //profile.SetPreference("browser.download.folderList", 0);
            //profile.SetPreference("browser.download.panel.shown", false);
            Thread.Sleep(2000);
            
            var pdf2 = Wait.Until(waitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("/html/body/app-root/app-main/div/div/div[2]/app-user-depot-seguimiento/p-panel/div/div[2]/div/p-tabview/div/div/p-tabpanel[2]/div/div[2]/div/p-datatable/div/div[2]/table/tbody/tr[7]/td[2]/span/div/button[2]")));
            profile.SetPreference("browser.download.folderList", 0);
            profile.SetPreference("browser.download.panel.shown", false);
            pdf2.Click();
           // IAlert alert1= Driver.SwitchTo().Alert();
            //alert1.Accept();
            //profile.SetPreference("browser.download.folderList", 0);
            //profile.SetPreference("browser.download.panel.shown", false);
            Thread.Sleep(2000);


            /* FirefoxProfile pro = new FirefoxProfile();
             pro.SetPreference("browser.downLoad.folderList", 0);
             pro.SetPreference("browser.helperApps.neverAsk.saveToDisk", "Applications/zip");*/
          //  FirefoxProfile profile = new FirefoxProfile();
           // profile.SetPreference("browser.download.dir", "C:\\Temp");  // folder
            //profile.SetPreference("browser.helperApps.neverAsk.saveToDisk", "video/mp4");  // MIME type
            //profile.SetPreference("pdfjs.disabled", true);  // disable the built-in viewer
            //profile.SetPreference("browser.download.folderList", 0);
            //profile.SetPreference("browser.download.panel.shown", false);

        }
        
        public SeguimientoPaquetesOrdenPage LoginSeguimientoOrden(string usuario,string pass)
        {
            Usuario(usuario);
            Password(pass);
            Ingresar();
            AbriMenu();
            ModuloEmpresa();
            Seguimiento();
            Thread.Sleep(2000);
            SeleccionarEmpresa();
            Thread.Sleep(2000);
            Sucursal();
            Thread.Sleep(2000);
            IngresarCodigo();
            Thread.Sleep(2000);
            Buscar();
            Thread.Sleep(2000);
            Galeria();
            //Thread.Sleep(2000);
            Scroll();
            //Thread.Sleep(2000);
             //CerrarGaleria();
            //Thread.Sleep(2000);
            //Pdf();
            return new SeguimientoPaquetesOrdenPage(Driver);

        }

    }
        
}


