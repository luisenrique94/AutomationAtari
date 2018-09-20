using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using waitHelpers = SeleniumExtras.WaitHelpers;

namespace Atari
{
    public class Planeamiento : BasePage
    {
        public Planeamiento(IWebDriver webDriver) : base(webDriver)
        {
        }
        public void Usuario(string user)
        {
            var usuario = Wait.Until(waitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("/html/body/app-root/app-login/div/div/form/div/div[2]/span/input")));
            Thread.Sleep(2000);
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
        public void planeamiento()
        {
            var planeamiento = Wait.Until(waitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("/html/body/app-root/app-main/div/div/div[1]/div/div[1]/app-menu/ul/li[3]/ul/li[2]/a")));
            Thread.Sleep(2000);
            planeamiento.Click();
        }
        public void B2bRegular()
        {
            try
            {
                var regular = Wait.Until(waitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("/html/body/app-root/app-main/div/div/div[2]/planeamientoform/div/div[6]/div[1]/div/div")));
                Thread.Sleep(2000);
                regular.Click();
            }
            catch (Exception)
            {

          
                    String mensaje="Tiempo superado ";
                  Console.WriteLine(mensaje);
                    
            }
            
        }
        public void Empresa()
        {
            var empresa = Wait.Until(waitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("/html/body/app-root/app-main/div/div/div[2]/planeamientoform/div/div[7]/div/div/div[4]/p-multiselect/div/div[2]/label")));
           // Thread.Sleep(2000);
            empresa.Click();
            //Thread.Sleep(200);
            var nombre = Wait.Until(waitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("/html/body/app-root/app-main/div/div/div[2]/planeamientoform/div/div[7]/div/div/div[4]/p-multiselect/div/div[4]/div[1]/div[2]/input")));
            nombre.Click();
            nombre.SendKeys("NESPRESSO");
            var all = Wait.Until(waitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("/html/body/app-root/app-main/div/div/div[2]/planeamientoform/div/div[7]/div/div/div[4]/p-multiselect/div/div[4]/div[1]/div[1]/div[2]")));
            all.Click();


        }
        public void Buscar()
        {
            var buscar = Wait.Until(waitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("/html/body/app-root/app-main/div/div/div[2]/planeamientoform/div/div[7]/div/div/div[1]/button")));
            buscar.Click();
        }
        public void MoverCard()
        {
            var mover = Wait.Until(waitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("/html/body/app-root/app-main/div/div/div[2]/planeamientoform/div/div[9]/p-toolbar/div/div[1]/button")));
            mover.Click();
            Thread.Sleep(2000);
            // var element = Driver.FindElement(By.XPath("/html/body/app-root/app-main/div/div/div[2]/planeamientoform/div/div[9]/div[1]/div[1]/div[1]/div"));
            // Actions actions = new Actions(Driver);
            //actions.MoveToElement(element).Build().Perform();
            //Mover
            //var from = Wait.Until(waitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("/html/body/app-root/app-main/div/div/div[2]/planeamientoform/div/div[9]/div[1]/div[1]/div[1]")));
            //Thread.Sleep(2000);
            //soltar
            //var To = Wait.Until(waitHelpers.ExpectedConditions.ElementIsVisible((By.XPath("/html/body/app-root/app-main/div/div/div[2]/planeamientoform/div/div[9]/div[1]/div[2]"))));
            // var To = Wait.Until(waitHelpers.ExpectedConditions.ElementIsVisible((By.XPath("/html/body/app-root/app-main/div/div/div[2]/planeamientoform/div/div[9]/div[1]/div[2]/p-datatable/div/div[1]"))));
            //var To = Wait.Until(waitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("/html/body/app-root/app-main/div/div/div[2]/planeamientoform/div/div[9]/div[1]/div[2]/p-datatable/div/div[1]/table/tbody/tr/td")));
            //Thread.Sleep(2000);
            //usando clase a mover 

            //arrastrar y soltar
            //Thread.Sleep(2000);
            //IAction dragAndDrop = act.ClickAndHold(from).MoveByOffset(-1,-1).MoveToElement(To).Release().Build();
            //dragAndDrop.Perform();
            //act.DragAndDrop(from, To).Release(To).Build().Perform();
            //  act.DragAndDrop(from, To);
            // act.Release(To);
            //Thread.Sleep(2000);
            //act.Build();
            //Thread.Sleep(2000);
            //act.Perform();
            //Thread.Sleep(2000);
            // act.Release();
            //Thread.Sleep(2000);
            //act.Release(To);
            //act.Build();
            // Thread.Sleep(2000);
            //act.Perform();
            //Thread.Sleep(2000);
            //  act.ClickAndHold(from).Build().Perform();
            // act.MoveToElement(To).Build().Perform();
            //act.Release(To).Build().Perform();
            //act.Release();
            /*
            IWebElement from = Driver.FindElement(By.XPath("/html/body/app-root/app-main/div/div/div[2]/planeamientoform/div/div[9]/div[1]/div[1]/div[1]/div"));
            IWebElement to = Driver.FindElement(By.XPath("/html/body/app-root/app-main/div/div/div[2]/planeamientoform/div/div[9]/div[1]/div[2]/p-datatable/div/div[1]"));
            act.DragAndDrop(from, to);
            act.Build();
            act.Perform();
            act.Release();
            */
            // Thread.Sleep(2000);

            // Thread.Sleep(2000);
            // act.Release(to).Build().Perform();
        }

        public void GenerarRuta()
        {
            try
            {
                var ruta = Wait.Until(waitHelpers.ExpectedConditions.ElementExists(By.XPath("/html/body/app-root/app-main/div/div/div[2]/planeamientoform/div/div[9]/div[1]/div[2]/p-datatable/div/div[1]/table/tbody/tr/td[3]")));
                ruta.Click();
                Thread.Sleep(2000);
            }
            catch (Exception)
            {

                throw;
            }
            
          
            var inicio = Wait.Until(waitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("/html/body/app-root/app-main/div/div/div[2]/planeamientoform/div/div[9]/p-toolbar/div/div[2]/button[2]")));
            inicio.Click();
            Thread.Sleep(2000);
            var yes = Wait.Until(waitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("/html/body/app-root/app-main/div/div/div[2]/planeamientoform/p-confirmdialog/div/div[3]/button[1]")));
            yes.Click();
            Thread.Sleep(2000);
            var generar = Wait.Until(waitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("/html/body/app-root/app-main/div/div/div[2]/planeamientoform/div/div[9]/p-toolbar/div/div[2]/button[1]")));
            generar.Click();
            Thread.Sleep(2000);
            var yes2 = Wait.Until(waitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("/html/body/app-root/app-main/div/div/div[2]/planeamientoform/p-confirmdialog/div/div[3]/button[1]")));
            yes2.Click();
          }
        public void AsignarMotorizado()
        {
            var rutasgeneradas = Wait.Until(waitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("/html/body/app-root/app-main/div/div/div[2]/planeamientoform/div/div[9]/p-toolbar/div/div[1]/md-chip-list/div/md-chip[2]/a")));
            rutasgeneradas.Click();
            Thread.Sleep(2000);
            var buscar = Wait.Until(waitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("/html/body/app-root/app-main/div/div/div[2]/planeamientoform/div/div[9]/div[2]/div/p-datalist/div/div[2]/ul/li[1]/div/div[8]/button")));
            buscar.Click();
            var vehiculos = Wait.Until(waitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("/html/body/app-root/app-main/div/div/div[2]/planeamientoform/previewprerouteform/p-dialog/div/div[2]/div/div/md-sidenav-container/div[4]/div[2]/div[2]/div/div[5]/p-multiselect/div/div[2]/label")));
            Thread.Sleep(2000);
            vehiculos.Click();
            var input = Wait.Until(waitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("/html/body/app-root/app-main/div/div/div[2]/planeamientoform/previewprerouteform/p-dialog/div/div[2]/div/div/md-sidenav-container/div[4]/div[2]/div[2]/div/div[5]/p-multiselect/div/div[4]/div[1]/div[2]/input")));
            Thread.Sleep(2000);
            input.Click();
            input.SendKeys("Motocicleta");
            var all = Wait.Until(waitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("/html/body/app-root/app-main/div/div/div[2]/planeamientoform/previewprerouteform/p-dialog/div/div[2]/div/div/md-sidenav-container/div[4]/div[2]/div[2]/div/div[5]/p-multiselect/div/div[4]/div[1]/div[1]/div[2]")));
            Thread.Sleep(2000);
            all.Click();
            var cerrar = Wait.Until(waitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("/html/body/app-root/app-main/div/div/div[2]/planeamientoform/previewprerouteform/p-dialog/div/div[2]/div/div/md-sidenav-container/div[4]/div[2]/div[2]/div/div[5]/p-multiselect/div/div[4]/div[1]/a")));
            Thread.Sleep(2000);
            cerrar.Click();
            
            var asociado = Wait.Until(waitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("/html/body/app-root/app-main/div/div/div[2]/planeamientoform/previewprerouteform/p-dialog/div/div[2]/div/div/md-sidenav-container/div[4]/div[2]/div[2]/div/div[7]/p-autocomplete/span/input")));
            Thread.Sleep(2000);
            asociado.Click();
            asociado.SendKeys("nieto");
            Thread.Sleep(2000);
            asociado.SendKeys(Keys.ArrowDown);
            Thread.Sleep(2000);
            asociado.SendKeys(Keys.Enter);

            var ofertar = Wait.Until(waitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("/html/body/app-root/app-main/div/div/div[2]/planeamientoform/previewprerouteform/p-dialog/div/div[2]/div/div/md-sidenav-container/div[4]/div[2]/div[2]/div/div[8]/button")));
            Thread.Sleep(2000);
            ofertar.Click();

            var yes = Wait.Until(waitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("/html/body/app-root/app-main/div/div/div[2]/planeamientoform/previewprerouteform/p-confirmdialog/div/div[3]/button[1]")));
            Thread.Sleep(2000);
            yes.Click();
        }
        //falta rutas generadas y asignar al motorizado  
        public Planeamiento LoginPlaneamiento(string usuario, string pass)
        {
            Usuario(usuario);
            Password(pass);
            Ingresar();
            AbriMenu();
            Thread.Sleep(2000);
            Operaciones();
            Thread.Sleep(2000);
            planeamiento();
            Thread.Sleep(2000);
            B2bRegular();
            Thread.Sleep(2000);
           //Empresa();
            //Thread.Sleep(2000);
            //Buscar();
            Thread.Sleep(2000);
            //MoverCard();
            Thread.Sleep(2000);
            //GenerarRuta();
            Thread.Sleep(2000);
            AsignarMotorizado();

            return new Planeamiento(Driver);

        }
    }


}

