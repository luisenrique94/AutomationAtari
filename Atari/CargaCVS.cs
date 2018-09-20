using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Threading;
using waitHelpers = SeleniumExtras.WaitHelpers;

namespace Atari
{
    public class CargaCVS : BasePage
    {
        // var empresa = "NESPRESSO MEXICO SA DE CV";
        public CargaCVS(IWebDriver webDriver) : base(webDriver)
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
        public void Operaciones()
        {
            var operaciones = Wait.Until(waitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("/html/body/app-root/app-main/div/div/div[1]/div/div[1]/app-menu/ul/li[3]/a")));
            operaciones.Click();
        }
        public void CargaCSV()
        {
            var carga = Wait.Until(waitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("/html/body/app-root/app-main/div/div/div[1]/div/div[1]/app-menu/ul/li[3]/ul/li[1]/a")));
            carga.Click();
        }
        public void NuevoCSV()
        {

            try
            {
                var nuevo = Wait.Until(waitHelpers.ExpectedConditions.ElementExists(By.XPath("//*[contains(text(),'Nuevo')]")));
                Thread.Sleep(2000);
                nuevo.Click();
            }
            catch (System.Exception)
            {

                throw;
            }
        }
        public void SocioNegocio()
        {

            try
            {
                var socio = Wait.Until(waitHelpers.ExpectedConditions.ElementExists(By.XPath("//*[@id='ui-tabpanel-0']/div/div[1]/p-dropdown/div/label")));
                socio.Click();
                Thread.Sleep(2000);

                var empresa = Wait.Until(waitHelpers.ExpectedConditions.ElementExists(By.XPath("//*[@id='ui-tabpanel-0']/div/div[1]/p-dropdown/div/div[3]/div[1]/input")));
                Thread.Sleep(2000);

                empresa.SendKeys("NESPRESSO");
                Thread.Sleep(2000);
                empresa.SendKeys(Keys.ArrowDown);
                empresa.SendKeys(Keys.Enter);

            }
            catch (System.Exception)
            {

                throw;
            }

        }
        public void Almacen()
        {
            try
            {
                var almacen = Wait.Until(waitHelpers.ExpectedConditions.ElementExists(By.XPath("//*[@id='ui-tabpanel-0']/div/div[2]/p-dropdown/div/label")));
                almacen.Click();
                Thread.Sleep(2000);

                var nombre = Wait.Until(waitHelpers.ExpectedConditions.ElementExists(By.XPath("//*[@id='ui-tabpanel-0']/div/div[2]/p-dropdown/div/div[3]/div[1]/input")));
                Thread.Sleep(2000);

                nombre.SendKeys("ALMACEN GEODIS");
                Thread.Sleep(2000);
                nombre.SendKeys(Keys.ArrowDown);
                nombre.SendKeys(Keys.Enter);

            }
            catch (System.Exception)
            {

                throw;
            }

        }
        public void SubirArchivo()
        {
            try
            {
                // var boton = Wait.Until(waitHelpers.ExpectedConditions.ElementExists(By.XPath("//*[@id='ui-tabpanel-0']/div[2]/div/p-fileupload/span")));
                var carga = Wait.Until(waitHelpers.ExpectedConditions.ElementExists(By.XPath("//*[@id='ui-tabpanel-0']/div[2]/div/p-fileupload/span/input")));
                carga.SendKeys("C:\\Users\\Admin\\Desktop\\EXCEL DE PRUEBA\\PRUEBAS_NESSPRESO_5.csv");
                Thread.Sleep(2000);
                
                var subir = Wait.Until(waitHelpers.ExpectedConditions.ElementExists(By.XPath("//*[@id='ui-tabpanel-0']/div[2]/div/p-fileupload/span")));
                subir.Click();
                Thread.Sleep(2000);
            }
            catch (System.Exception)
            {

                throw;
            }
        }
        public void Continuar()
        {
            var continuar=Wait.Until(waitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='ui-tabpanel-1']/div/div[2]/div/button")));
            continuar.Click();
        }
        public void Yes1()
        {
            var yes = Wait.Until(waitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("/html/body/app-root/app-main/div/div/div[2]/loadcsvform/p-confirmdialog/div/div[3]/button[1]")));
            yes.Click();
        }
        public void Finalizar()
        {
            var finalizar = Wait.Until(waitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='ui-tabpanel-2']/div/div[1]/div/button")));
            finalizar.Click();
        }
        public void Yes2()
        {
            var yes = Wait.Until(waitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("/html/body/app-root/app-main/div/div/div[2]/loadcsvform/p-confirmdialog/div/div[3]/button[1]")));
            yes.Click();
        }
        public Planeamiento LoginCargaCSV(string usuario, string pass)
        {
            Usuario(usuario);
            Password(pass);
            Ingresar();
            AbriMenu();
            Thread.Sleep(2000);
            Operaciones();
            Thread.Sleep(2000);
            CargaCSV();
            Thread.Sleep(2000);
            NuevoCSV();
            Thread.Sleep(2000);
            SocioNegocio();
            Thread.Sleep(2000);
            Almacen();
            Thread.Sleep(2000);
            SubirArchivo();
            Thread.Sleep(2000);
            Continuar();
            Thread.Sleep(2000);
            Yes1();
            Thread.Sleep(2000);
            Finalizar();
            Thread.Sleep(2000);
            Yes2();
            return new Planeamiento(Driver);

        }
    }
}
